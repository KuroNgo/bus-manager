<script>
import { RouterLink, RouterView } from 'vue-router'
import HeaderView from './components/HeaderView.vue'

export default {
  components :{
    HeaderView
  }
}
</script>

<template>
  <header>
    <HeaderView />
      <nav>
        <!-- <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/about">About</RouterLink> -->
      </nav>
  </header>

  <RouterView />
</template>

<style scoped>

</style>
