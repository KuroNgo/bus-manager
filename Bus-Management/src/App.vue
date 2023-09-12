<template>
  <HeaderView v-if="show" />
  <router-view class=" font-body"> </router-view>
  <FooterView v-if="show" />
</template>
<script>
import HeaderView from './components/HeaderView.vue';
import FooterView from './components/FooterView.vue';
import { RouterLink } from 'vue-router';
export default {
  data() {
    return {

    }
  },
  components: {
    HeaderView,
    FooterView,
    RouterLink
  },
  computed :{
    show(){
     return this.$route.name == 'Home | Bus Management' || this.$route.name == 'About | Bus Management' || this.$route.name == 'Service | Bus Management' || this.$route.name == 'Contact | Bus Management'
    }
  }
}
</script>
<style>
/* @import url('https://fonts.googleapis.com/css2?family=Odibee+Sans&family=Poppins&display=swap'); */
</style>

