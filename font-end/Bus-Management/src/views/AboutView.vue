<template>
  <main class="">
    <div class=" mb-52">
      <div class="flex justify-between items-center">
        <div class=" w-1/2">
          <img class=" w-full" src="../../public/assets/img/viewinbus.png" alt="">
        </div>
        <div class="w-1/2 px-36 py-16">
          <h4 class=" mb-10 text-BlackColor text-2xl font-bold">Who are we?</h4>
          <p>We are a passionate and dedicated team on a mission to provide the best public transportation service in
            Dalat.
            With a love for transportation and a desire to contribute to the sustainable development of the city, we have
            created the Dalat Bus Route Management website. Born out of our love for nature and a commitment to enhancing
            the quality of life for residents and visitors, we pledge to provide detailed information and top-notch
            support
            services to ensure your travel experience in Dalat is as convenient and enjoyable as possible.</p>
        </div>
      </div>

      <div class="flex justify-between items-center">
        <div class="w-1/2 px-36 py-16">
          <h4 class=" mb-10 text-BlackColor text-2xl font-bold">Startup Story</h4>
          <p>Rooted in commuter frustrations, our founders set out on a mission to simplify bus navigation. Fuelled by
            their own experiences, they envisioned a platform to manage bus fleets and empower commuters. Through
            dedication and innovation, our user-friendly tool emerged, offering seamless access to schedules, live route
            updates, and easy navigation. Our story reflects a commitment to transform daily commutes into smooth
            experiences, redefining public transportation, one bus route at a time.</p>
        </div>
        <div class=" w-1/2">
          <img class="w-full" src="../../public/assets/img/bus-img.jpg" alt="">
        </div>
      </div>
    </div>

    <div class="px-28 mb-20">
      <h3 class=" text-3xl font-semibold text-BlackColor text-center mb-16">Our Services</h3>
      <div class="flex justify-around items-center mb-20">
        <div class=" w-2/5">
          <!-- <img src="../../public/assets/img/ux-city-bus-rafiki-1.png" alt=""> -->
          <div class=" flex justify-center">
            <font-awesome-icon class=" p-9 text-[250px]" icon="fa-solid fa-map-location-dot" style="color: #3b78e3;" />
          </div>
          <h4 class=" my-3  text-BlackColor text-2xl font-bold">Bus Route Search</h4>
          <span class=" text-xl text-BlackColor font-normal">Offering a search function to find bus routes based on
            desired origin and destination, displaying detailed information about routes and schedules</span>
        </div>
        <div class=" w-2/5">
          <!-- <img src="../../public/assets/img/ux-city-bus-rafiki-1.png" alt=""> -->
          <div class=" flex justify-center">
            <font-awesome-icon class=" p-9 text-[250px]" icon="fa-solid fa-hourglass-start" style="color: #3b78e3;" />
          </div>
          <h4 class=" my-3  text-BlackColor text-2xl font-bold">Real-Time Map Tracking</h4>
          <span class=" text-xl text-BlackColor font-normal">Displaying real-time bus locations on a map, allowing users
            to accurately track bus arrival times at specific stops.</span>
        </div>
      </div>
      <div class="flex justify-around items-center">
        <div class=" w-2/5">
          <!-- <img src="../../public/assets/img/ux-city-bus-rafiki-1.png" alt=""> -->
          <div class=" flex justify-center">
            <font-awesome-icon class=" p-9 text-[250px]" icon="fa-solid fa-map-pin" style="color: #3b78e3;" />
          </div>
          <h4 class=" my-3  text-BlackColor text-2xl font-bold">Schedule Information and Stops</h4>
          <span class=" text-xl text-BlackColor font-normal"> Providing detailed schedules for each bus route and
            information about stops along the way, enabling users to choose based on their preferences.</span>
        </div>
        <div class=" w-2/5">
          <div class=" flex justify-center">
            <font-awesome-icon class=" p-9 text-[250px]" icon="fa-solid fa-route" style="color: #3b78e3;" />
          </div>
          <h4 class=" my-3  text-BlackColor text-2xl font-bold">Directions and Navigation Feature</h4>
          <span class=" text-xl text-BlackColor font-normal">Offering comprehensive guidance on navigating from point A to
            point B using bus routes, including detailed routes and various directional options.</span>
        </div>
      </div>

    </div>

    <div class="px-28 py-20">
      <h2 class=" text-4xl font-bold text-BlackColor text-center mb-16">Leaders</h2>
      <div class="flex justify-around items-center">
        <div class=" w-1/4 rounded-3xl p-11 bg-ThirdColor flex flex-col justify-center items-center">
          <div class=" w-64 h-64 rounded-full flex justify-center items-center mb-4">
            <font-awesome-icon class=" text-[200px]" style="color: #3b78e3;" icon="fa-solid fa-user-tie" />
          </div>

          <h3 class=" font-semibold text-3xl text-BlackColor mb-4">Doan Dinh Hoang</h3>

          <h4 class=" font-bold text-2xl text-BlackColor mb-4">Font End</h4>
          <span class=" text-xl font-medium text-BlackColor">“Never give up on your dream”</span>
        </div>

        <div class=" w-1/4 rounded-3xl p-11 bg-ThirdColor flex flex-col justify-center items-center">
          <div class=" w-64 h-64 rounded-full flex justify-center items-center mb-4">
            <font-awesome-icon class=" text-[200px]" style="color: #3b78e3;" icon="fa-solid fa-user-ninja" />
          </div>

          <h3 class=" font-semibold text-3xl text-BlackColor mb-4">Ngo Hoai Phong</h3>
          <h4 class=" font-bold text-2xl text-BlackColor mb-4">Back End</h4>

          <span class=" text-xl font-medium text-BlackColor">“Never give up on your dream”</span>
        </div>

        <div class=" w-1/4 rounded-3xl p-11 bg-ThirdColor flex flex-col justify-center items-center">
          <div class=" w-64 h-64 rounded-full flex justify-center items-center mb-4">
            <font-awesome-icon class=" text-[200px]" style="color: #3b78e3;" icon="fa-solid fa-user-astronaut" />
          </div>

          <h3 class=" font-semibold text-3xl text-BlackColor mb-4">Nguyen Ngoc Son</h3>

          <h4 class=" font-bold text-2xl text-BlackColor mb-4">Font End</h4>
          <span class=" text-xl font-medium text-BlackColor">“Never give up on your dream”</span>
        </div>
      </div>
    </div>
  </main>
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