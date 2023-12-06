<template>
  <main class="">
    <SidebarView />
  </main>
</template>
  
<script>
import SidebarView from '../components/SidebarView.vue';
export default{
  components:{
    SidebarView
  },
  data(){
    return{
      searchValue : null
    }
  },
  created(){
    // this.x = this.$route.query.x
  }
}
</script>
  
<style scoped>
</style>
