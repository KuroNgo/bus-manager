<template>
    <main class="flex">
      <Sidebar />
  
    </main>

  </template>
  
  <script>
  import HeaderView from '../components/HeaderView.vue'
  import FooterView from '../components/FooterView.vue';

  import Sidebar from '../components/SidebarView.vue'
  export default {
    components: {
      HeaderView,
      FooterView,
      Sidebar

    }
  }
  </script>
  
  <style scoped></style>