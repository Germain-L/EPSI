<script>
  import { onMount } from "svelte";
  import { slide, fade } from "svelte/transition";
  let isVisible = false;
</script>

<button on:click={() => (isVisible = !isVisible)}
  >{isVisible ? "Fermer les infos" : "Devoiler des infos"}</button
>
{#if isVisible}
  <div class="space-y-6" in:slide out:fade>
    <h1>Comment ce site fonctionne-t-il ?</h1>
    <p>Un menu burger donne accès a 2 pages : contact et about</p>
    <h1>Contact</h1>
    <p>Un formulaire permet de rentrer ces données</p>
    <p>Ensuite une fonction envoie les données vers une api interne (POST)</p>
    <p>L'api renvoie si il y a des erreurs dans le formulaire</p>
    <ul>
      <li>Si il y a bien tout les éléments</li>
      <li>Si l'email est bien valide</li>
    </ul>
    <p>Puis ces erreurs sont affichées à l'utilisateur</p>
    <p>Si tout est bon un redirect est effectué pour quitter le formulaire</p>
  </div>
{/if}

<style lang="postcss">
  h1 {
    font-size: 2em;
  }

  ul {
    list-style-type: disc;
    list-style-position: inside;
  }
</style>
