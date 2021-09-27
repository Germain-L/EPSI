<script>
  import { fade } from "svelte/transition";
  import { expoOut } from "svelte/easing";

  function spin(node, { duration }) {
    return {
      duration,
      css: (t) => {
        const eased = expoOut(t);

        return `
					transform: scale(${eased}) rotate(${eased * 360}deg);
					color: hsl(
						${~~(t * 360)},
						${Math.min(100, 1000 - 1000 * t)}%,
						${Math.min(50, 500 - 500 * t)}%
					);`;
      },
    };
  }
</script>

<div class="centered" in:spin={{ duration: 8000 }} out:fade>
  <span>About page</span>
</div>

<style>
  .centered {
    position: absolute;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%);
  }

  span {
    position: absolute;
    transform: translate(-50%, -50%);
    font-size: 4em;
  }
</style>
