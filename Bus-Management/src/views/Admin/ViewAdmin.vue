<template>
 <div className="min-h-screen flex flex-row bg-gray-100">
      <SideBar></SideBar>
      
    </div>
  
 
</template>

<script>
import SideBar from '../../views/Admin/SideBar.vue';
import AccountManagerView from '../../views/Admin/AccountManagerView.vue';

export default {
    components: {
    SideBar,
   AccountManagerView,
    }
}
</script>

<style>
.container {
  position: relative;
}

.SideBar {
  position: absolute;
  left: 0;
  top: 0;
}

.AccountManagerView {
  position: absolute;
  right: 0;
  bottom: 0;
}
</style>