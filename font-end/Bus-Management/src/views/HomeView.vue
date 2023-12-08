<template>
  <main class=" ">
    <!--------------------------------------------- Slider -->
    <div class=" bg-SecondColor px-28 flex items-center justify-between mb-32" style="height: 100vh;">
      <div class=" w-2/5 flex flex-col gap-y-5">
        <span class=" text-xl font-medium text-BlackColor">Welcome to BusDaLat</span>
        <h1 class=" text-5xl font-extrabold text-BlackColor">Connecting Journeys, Easy and Convenient!</h1>
        <p class=" text-base font-medium text-BlackColor">Explore the incredible convenience of the bus route lookup
          website - Your smart and efficient journey companion!</p>

        <div class=" flex gap-x-4 ">
          <RouterLink to="/service">
            <button @click="test1()" class=" text-xl w-36 font-medium text-MainColor p-3 bg-FourColor rounded-2xl">Get
              start</button>
          </RouterLink>
          <form class=" flex gap-x-3 items-center w-96 bg-ThirdColor px-3 py-4 rounded-2xl">
            <font-awesome-icon class=" text-FourColor" icon="fa-solid fa-location-dot" />
            <input v-model="searchValue" type="text"
              class="text-base font-medium text-BlackColor w-full bg-ThirdColor outline-none" maxlength="100">
          </form>
        </div>

      </div>
      <div class=" w-1/2">
        <img class="w-full" src="../../public/assets/img/ux-city-bus-rafiki-1.png" alt="">
      </div>
    </div>
    <!--------------------------------------------- Slider -->

    <!--------------------------------------------- Popular -->
    <div class="px-28 bg-MainColor mb-52 ">
      <div class="flex justify-between">
        <h2 class=" text-4xl font-bold text-BlackColor mb-28">Popular bus routes</h2>
        <RouterLink to="/service">
          <p class=" font-medium underline text-xl text-BlackColor">Xem thêm</p>
        </RouterLink>
      </div>
      <SlidesView />
    </div>
    <!--------------------------------------------- Popular -->
    <!--------------------------------------------- Features -->
    <div class="px-28 bg-SecondColor py-8 mb-52">
      <h2 class=" text-4xl font-bold text-BlackColor mb-28">Popular bus routes</h2>
      <div class="flex flex-wrap justify-between items-center gap-56">
        <div class="  w-96 text-center flex flex-col px-2 py-6 items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-regular fa-hourglass-half" style="color: #457bd9;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">Real-Time Information</h4>
          <span class=" font-medium text-xl text-BlackColor">Track real-time bus schedules, know accurate arrival and
            departure times.</span>
        </div>

        <div class="  w-96 text-center flex flex-col px-2 py-6 items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-solid fa-road-circle-check" style="color: #376ecd;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">Efficient Planning</h4>
          <span class=" font-medium text-xl text-BlackColor">Easily set schedules, find alternative routes when
            needed</span>
        </div>

        <div class="  w-96 text-center flex flex-col px-2 py-6 items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-brands fa-sketch" style="color: #3878e5;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">User-Friendly Interface</h4>
          <span class=" font-medium text-xl text-BlackColor">Smooth user experience, effortless information
            retrieval.</span>
        </div>

        <div class=" w-96 text-center flex flex-col  px-2 py-6items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-regular fa-map" style="color: #3a78e4;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">Customizable Routes</h4>
          <span class=" font-medium text-xl text-BlackColor">Input starting and destination points for personalized route
            suggestions.</span>
        </div>

        <div class=" w-96 text-center flex flex-col  px-2 py-6items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-solid fa-wrench" style="color: #3575e3;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">Service Updates</h4>
          <span class=" font-medium text-xl text-BlackColor">Stay informed about alerts, disruptions, and the latest
            service news.</span>
        </div>

        <div class=" w-96 text-center flex flex-col  px-2 py-6items-center justify-center">
          <font-awesome-icon class=" mb-8 text-6xl" icon="fa-solid fa-wand-magic-sparkles" style="color: #3b78e3;" />
          <h4 class=" font-bold text-2xl mb-8 text-BlackColor">Daily Convenience</h4>
          <span class=" font-medium text-xl text-BlackColor">Enhance your bus travel with convenience and smart
            choices.</span>
        </div>
      </div>
    </div>
    <!--------------------------------------------- Features -->
    <!--------------------------------------------- Support -->
    <div class="px-28 flex justify-between items-center mb-52">
      <div class=" w-1/2">
        <h2 class=" text-4xl font-bold text-BlackColor mb-9">Support 24/7</h2>
        <p class="font-medium text-xl text-BlackColor mb-9">BA GPS has built strategies to enhance the position in the
          domestic market as well as international market</p>
        <button class=" mb-14 text-base block font-medium text-MainColor bg-FourColor px-2 py-3 rounded-3xl w-52">View
          detail</button>
        <div class="flex items-center mb-10 justify-start gap-8">
          <font-awesome-icon class=" w-[67.5px] text-6xl" icon="fa-solid fa-location-dot" style="color: #3b78e3;" />
          <div class=" p-3">
            <h4 class=" font-bold text-2xl text-BlackColor">Bus route tracking</h4>
            <span class=" font-medium text-xl text-BlackColor">Real-time bus locations and schedules.</span>
          </div>
        </div>
        <div class="flex items-center mb-10 justify-start gap-8">
          <font-awesome-icon class=" text-6xl" icon="fa-solid fa-wand-magic-sparkles" style="color: #3b78e3;" />
          <div class=" p-3">
            <h4 class=" font-bold text-2xl text-BlackColor">Route navigation</h4>
            <span class=" font-medium text-xl text-BlackColor">Precise and comprehensive directions.</span>
          </div>
        </div>
        <div class="flex items-center justify-start gap-8">
          <font-awesome-icon class=" w-[67.5px] text-6xl" icon="fa-solid fa-magnifying-glass" style="color: #3b78e3;" />
          <div class=" p-3">
            <h4 class=" font-bold text-2xl text-BlackColor">Transit route search</h4>
            <span class=" font-medium text-xl text-BlackColor"> Locate public transportation options.</span>
          </div>
        </div>
      </div>
      <div class="w-1/2">
        <img class="w-full" src="../../public/assets/img/BusLogin.png" alt="">
      </div>
    </div>
    <!--------------------------------------------- Support -->
    <!--------------------------------------------- FeedBack -->
    <div class="px-28 bg-SecondColor py-28">
      <h2 class=" text-4xl font-bold text-BlackColor mb-28">What Our Clients Say About Us</h2>
      <SlidesFeedBackView />
    </div>
    <!--------------------------------------------- FeedBack -->






  </main>
</template>

<script>
import SlidesFeedBackView from '../components/SlidesFeedBack/SlidesFeedBackView.vue';
import FooterView from '../components/FooterView.vue';
import HeaderView from '../components/HeaderView.vue';
import SlidesView from '../components/SlidesCard/SlidesView.vue'
export default {
  data() {
    return {
      x: 2,
      searchValue: '',
    }
  },
  components: {
    HeaderView,
    FooterView,
    SlidesView,
    SlidesFeedBackView
  },
  methods: {
    test1() {
      localStorage.clear();
      // this.$router.push({path:'/service', query :{ x : this.x}})
      localStorage.setItem('searchValue', this.searchValue);
    }
  }
}
</script>

<style scoped></style>