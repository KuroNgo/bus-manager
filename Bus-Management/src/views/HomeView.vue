<template>
  <HeaderView />
  <main class="mainbg">
    <!-- Slider -->
    <div class="bg flex justify-between items-center px-36 ">
      <div class="w w-2/4 text-start">
        <h1 class="text text-slate-100  text-4xl font-extrabold mb-4">Bus Operation & Fleet management system</h1>
        <p class="text text-slate-100  text-xl mb-6">Bus fleet management simultaneously over multiple routes in real time
        </p>
        <button class="text text-slate-100 font-thin text-xl bnt rounded-3xl px-16 py-4">Get Start</button>
      </div>

      <div class="d w-">
        <img class="w w-full " src="./assets/img/gifmartcity.gif" alt="">
      </div>
    </div>

    <!-- OverView -->
    <div class="bg2 px-36">
      <h1 class="textblow text-center text-9xl opacity-10 font-bold text-slate-100 mb-5">FEATURES</h1>
      <h1 class="textabove text-center text-6xl font-medium text-slate-100 mb-5">Our Unique & Awesome <br> Core Features
      </h1>
      <p class="text-center m-auto text-base text-slate-400  w-1/3">Lorem ipsum dolor sit amet consectetur adipisicing
        elit. aceat quidem?Accusantium.</p>
      <div class="flex flex-wrap justify-around items-center w-full flex-wrap-reverse mt-20">

        <div class="w lg:w-1/3 md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>

        <div class="w lg:w-1/3  md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>

        <div class="w lg:w-1/3  md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>

        <div class="w lg:w-1/3  md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>

        <div class="w lg:w-1/3  md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>

        <div class="w lg:w-1/3  md:w-1/2 flex flex-col justify-center items-center gap-y-5 p-4 ">
          <div class="boxcircle  rounded-full p-5 bg-gray-400">
            <font-awesome-icon class="text text-6xl" icon="fa-solid fa-bars-progress" />

          </div>
          <h1 class="text text-2xl font-semibold text-slate-100">Crafted for Startups</h1>
          <p class="text-center mb-16 text-slate-400 ">Lorem ipsum dolor sit amet, consectetur <br> adipiscing elit. In
            convallis tortor.</p>
        </div>
      </div>
    </div>


    <div class="bg2 px-36 h-screen">
      <h1 class="textblow text-center text-9xl opacity-10 font-bold text-slate-100 mb-5">Testimonial</h1>
      <h1 class="textabove text-center text-6xl font-medium text-slate-100 mb-5">What Our Clients <br> Say About Us</h1>
      <p class="text-center m-auto text-base text-slate-400  w-1/3">Lorem ipsum dolor sit amet consectetur adipisicing
        elit. aceat quidem?Accusantium.</p>
      <div class="text bg-slate-600">
        
      </div>
    </div>
  </main>
  <FooterView />
</template>

<script>
import FooterView from '../components/FooterView.vue';
import HeaderView from '../components/HeaderView.vue';
export default {
  components: {
    HeaderView,
    FooterView
  },
}
</script>

<style scoped>
.bg {
  background: #1e1250;
  background: rgb(49, 24, 65);
  background: linear-gradient(159deg, rgba(49, 24, 65, 1) 7%, rgba(30, 18, 80, 1) 31%);
  
  height: 100vh;
}




.bnt {
  background: rgb(51, 148, 196);
  background: linear-gradient(180deg, rgba(51, 148, 196, 0.896796218487395) 47%, rgba(89, 197, 194, 0.7679446778711485) 81%);

}

.textabove {
  margin-top: -64px;
}

.textblow {
  color: rgb(125 111 183 / 91%);
}

.bnt:hover {
  background: rgb(63, 94, 251);
  background: radial-gradient(circle, rgba(63, 94, 251, 1) 0%, rgba(252, 70, 107, 1) 100%);

}

.w:hover .boxcircle {
  background: #463aab;
}


/* .bg2 {
  background: rgb(49, 24, 65);
  background: linear-gradient(3deg, rgba(49, 24, 65, 1) 25%, rgba(30, 18, 80, 1) 87%);
  height: 100vh;

} */

li {
  list-style: circle;
}</style>