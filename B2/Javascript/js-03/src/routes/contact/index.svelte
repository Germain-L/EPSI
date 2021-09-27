<script lang="ts">
  import { goto } from "$app/navigation";
  import { slide } from "svelte/transition";

  let subject = "";
  let email = "";
  let message = "";
  let errorMessage = "";
  let successMessage = "";

  async function send() {
    const response: Response = await fetch("/contact", {
      method: "POST",
      body: JSON.stringify({
        subject: subject,
        email: email,
        message: message,
      }),
    });

    if (response.status !== 200) {
      const responseBody = await response.json();
      errorMessage = responseBody.text;
    } else if (response.status === 200) {
      errorMessage = "";
      const responseBody = await response.json();
      successMessage = responseBody.text;

      setTimeout(() => goto("/thanks"), 2000);
    }
  }
</script>

<form
  action="/contact"
  method="POST"
  enctype="multipart/form-data"
  class="space-y-6"
  on:submit|preventDefault={send}
>
  <h1 class="text-xl md:text-2xl lg:text-4xl">Envoie moi un email</h1>
  <div class="space-y-3">
    <label for="email">Email *</label>
    <input
    type="text"
    name="email"
    id="email"
    bind:value={email}
    class="w-full px-3 py-2  border border-gray-300 rounded-md focus:outline-none focus:ring focus:ring-blue-100 focus:border-blue-300 "
    />
  </div>
  <div class="space-y-3">
    <label for="name">Sujet *</label>
    <input
      type="text"
      name="subject"
      id="subject"
      bind:value={subject}
      class="w-full px-3 py-2  border border-gray-300 rounded-md focus:outline-none focus:ring focus:ring-blue-100 focus:border-blue-300 "
    />
  </div>

  <div class="flex flex-col space-y-3">
    <label for="message">Message *</label>
    <textarea
      name="message"
      id="message"
      cols="30"
      rows="10"
      bind:value={message}
      class="w-full px-3 py-2  border border-gray-300 rounded-md focus:outline-none focus:ring focus:ring-blue-100 focus:border-blue-300 "
    />
  </div>

  <div class="flex flex-col justify-center text-center space-y-6">
    {#if errorMessage}
      <p in:slide out:slide class="text-red-500 text-sm">
        {errorMessage}
      </p>
    {/if}
    {#if successMessage}
      <p in:slide out:slide class="text-green-500 text-sm">
        {successMessage}
      </p>
    {/if}
    <button
      type="submit"
      class="py-2 px-4 border border-transparent text-sm font-medium rounded-md text-black bg-white ring-2 hover:bg-blue-300 focus:ring-offset-2 focus:ring-blue-500"
      >Envoyer</button
    >
  </div>
</form>
