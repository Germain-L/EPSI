<script>
  import "../app.postcss";
  import Header from "../components/Header.svelte";
</script>

<div class="m-4 md:m-24 md:mt-4">
  <Header />
  <div class="w-full flex flex-row justify-center">
    <div class="w-11/12 md:w-6/12 flex flex-col space-y-6">
      <slot />
    </div>
  </div>
</div>
