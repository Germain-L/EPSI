<script lang="ts">
  import { slide, fade } from "svelte/transition";
  let isVisible = false;

  const closeNav = function (): void {
    isVisible = false;
  };
</script>

<div class="flex flex-col visible m-4">
  <div class="flex flex-row items-center justify-between mb-4">
    <a
      on:click={closeNav}
      class="title text-3xl font-bold md:text-4xl lg:text-5xl"
      href="/">Site de Germain</a
    >
    <button on:click={() => (isVisible = !isVisible)}>
      {#if isVisible}
        <svg
          in:slide={{ delay: 200 }}
          out:fade={{ duration: 200 }}
          xmlns="http://www.w3.org/2000/svg"
          height="24px"
          viewBox="0 0 24 24"
          width="24px"
          fill="#000000"
          ><path d="M0 0h24v24H0V0z" fill="none" />
          <path
            fill="#000000"
            d="M18.3 5.71c-.39-.39-1.02-.39-1.41 0L12 10.59 7.11 5.7c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41L10.59 12 5.7 16.89c-.39.39-.39 1.02 0 1.41.39.39 1.02.39 1.41 0L12 13.41l4.89 4.89c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L13.41 12l4.89-4.89c.38-.38.38-1.02 0-1.4z"
          /></svg
        >
      {:else}
        <svg
          in:slide={{ delay: 200 }}
          out:fade={{ duration: 200 }}
          xmlns="http://www.w3.org/2000/svg"
          height="24px"
          viewBox="0 0 24 24"
          width="24px"
          fill="#000000"
          ><path d="M0 0h24v24H0V0z" fill="none" />
          <path
            fill="#000000"
            d="M4 18h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zm0-5h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zM3 7c0 .55.45 1 1 1h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1z"
          /></svg
        >
      {/if}
    </button>
  </div>
  {#if isVisible}
    <div class="flex flex-col" transition:slide>
      <a
        class="font-medium hover:font-semibold h-8 flex flex-col items-end justify-center"
        on:click={closeNav}
        href="/contact">contact</a
      >
      <a
        class="font-medium hover:font-semibold h-8 flex flex-col items-end justify-center"
        on:click={closeNav}
        href="/"
      >
        home
      </a>
    </div>
  {/if}
</div>
