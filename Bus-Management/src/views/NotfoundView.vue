<template>
  <div>
    <HeaderView></HeaderView>

    <div class="bg-white">
      <div
        class="w-9/12 m-auto py-16 min-h-screen flex items-center justify-center"
      >
        <div class="bg-white sm:rounded-lg pb-8">
          <div class="border-t border-white text-center pt-8">
            <h1 class="text-9xl font-bold text-[#1a5b34e0]">404</h1>
            <h1 class="text-6xl font-medium py-8">oops! Page not found</h1>
            <p class="text-2xl pb-8 px-12 font-medium">
              Oops! The page you are looking for does not exist.
            </p>
            <button
              class="bg-gradient-to-r from-purple-400 to-[#1a5b34e0] hover:from-pink-500 hover:to-[#1a5b34e0] text-white font-semibold px-6 py-3 rounded-md mr-6"
            >
              HOME
            </button>
            <button
              class="bg-gradient-to-r from-red-400 to-[#1a5b34e0] hover:from-red-500 hover:to-[#1a5b34e0] text-white font-semibold px-6 py-3 rounded-md"
            >
              Contact Us
            </button>
          </div>
        </div>
      </div>
    </div>

    <FooterView></FooterView>
  </div>
</template>
<script>
import HeaderView from "../components/HeaderView.vue";
import FooterView from "../components/FooterView.vue";
export default {
  components: {
    HeaderView,
    FooterView,
  },
};
</script>

<style type="text/css">
.text-9xl {
  font-size: 14rem;
}
@media (max-width: 645px) {
  .text-9xl {
    font-size: 5.75rem;
  }
  .text-6xl {
    font-size: 1.75rem;
  }
  .text-2xl {
    font-size: 1rem;
    line-height: 1.2rem;
  }
  .py-8 {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }
  .px-6 {
    padding-left: 1.2rem;
    padding-right: 1.2rem;
  }
  .mr-6 {
    margin-right: 0.5rem;
  }
  .px-12 {
    padding-left: 1rem;
    padding-right: 1rem;
  }
}
</style>
