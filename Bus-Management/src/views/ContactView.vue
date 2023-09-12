<template>
  <!-- <HeaderView /> -->
  <main class="flex justify-center items-center h-screen">
    <div class=" w-4/5 flex justify-between items-center px-20 py-10 bg-ThirdColor">
      <div class=" w-1/3">
        <h2 class=" text-3xl font-bold text-FourColor">Let’s get in touch</h2>
        <p class=" text-base font-medium text-MainColor">Hey there, we’re appreciate if you can send us a message to make our website get better. Your opinion is very
          helpful for us to improve the website more develop. Thank you !</p>
      </div>
      <div class=" w-2/5">
        <form class=" mb-8">
          <label class="text-xl font-medium text-BlackColor">Email</label>
          <input class=" mt-1 w-full rounded-2xl py-4 px-2" type="email">
        </form>

        <form class=" mb-8">
          <label class="text-xl font-medium text-BlackColor">Name</label>
          <input class=" mt-1 w-full rounded-2xl py-4 px-2" type="text">
        </form>

        <form class=" mb-8">
          <label class="text-xl font-medium text-BlackColor">Phone</label>
          <input class=" mt-1 w-full rounded-2xl py-4 px-2" type="text">
        </form>
        <form class=" mb-10">
          <label class="text-xl font-medium text-BlackColor">Message</label>
          <textarea class="mt-1 block w-full rounded-2xl" name="" id="" cols="30" rows="10"></textarea>
        </form>
        <button class="w-full bg-FourColor rounded-2xl py-4 px-2 text-base font-medium text-MainColor">Send</button>
      </div>
    </div>
  </main>
  <!-- <FooterView /> -->
</template>
  
<script>
import HeaderView from '../components/HeaderView.vue'
import FooterView from '../components/FooterView.vue';
export default {
  components: {
    HeaderView,
    FooterView
  }
}
</script>
  
<style scoped></style>