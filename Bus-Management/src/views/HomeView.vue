<template>
  <HeaderView />
  <main class=" ">
    <!--------------------------------------------- Slider -->
    <div class=" bg-SecondColor px-28 flex items-center justify-between mb-32" style="height: 100vh;">
      <div class=" w-2/5 flex flex-col gap-y-5">
        <span class=" text-xl font-medium text-BlackColor">Welcome to BusDaLat</span>
        <h1 class=" text-5xl font-extrabold text-BlackColor">Connecting Journeys, Easy and Convenient!</h1>
        <p class=" text-base font-medium text-BlackColor">Explore the incredible convenience of the bus route lookup website - Your smart and efficient journey companion!</p>
      
        <div class=" flex gap-x-4 ">
          <button class=" text-xl w-36 font-medium text-MainColor p-3 bg-FourColor rounded-2xl">Get start</button>
          <form class=" flex gap-x-3 items-center w-96 bg-ThirdColor px-3 py-4 rounded-2xl">
            <font-awesome-icon class=" text-FourColor" icon="fa-solid fa-location-dot" />
            <input type="text" class="text-base font-medium text-BlackColor w-full bg-ThirdColor outline-none" maxlength="100">
          </form>
        </div>
      
      </div>
      <div class=" w-1/2">
        <img class="w-full" src="./assets/img/ux-city-bus-rafiki-1.png" alt="">
      </div>
    </div>
    <!--------------------------------------------- Slider -->

    <!--------------------------------------------- Popular -->
    <div class="px-28 bg-MainColor ">
      <h2 class=" text-4xl font-bold text-BlackColor mb-28">Popular bus routes</h2>
      <div class="flex justify-around mb-14">
        <CardView />
        <CardView />
        <CardView />
      </div>

      <div class=" flex justify-center gap-2">
        <button class=" w-12 rounded-xl h-2 bg-FourColor"></button>
        <button class=" w-12 rounded-xl h-2 bg-slate-400"></button>
        <button class=" w-12 rounded-xl h-2 bg-slate-400"></button>
      </div>
    </div>
    <!--------------------------------------------- Popular -->


    
    
  </main>
  <FooterView />
</template>

<script>
import FooterView from '../components/FooterView.vue';
import HeaderView from '../components/HeaderView.vue';
import CardView from '../components/Card/CardView.vue'
export default {
  components: {
    HeaderView,
    FooterView,
    CardView
  },
}
</script>

<style scoped>
</style>