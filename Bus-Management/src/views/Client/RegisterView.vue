<template>
    <div>
      <!-- <HeaderView /> -->
  
      <div class="flex items-center justify-center min-h-screen bg-gray-100">
      <div class="px-8 py-6 mx-4 mt-4 text-left bg-white shadow-lg md:w-1/3 lg:w-1/3 sm:w-1/3">
          <div class="flex justify-center">
              <img src="../../../public/assets/img/buslogo.png">
          </div>
          <h3 class="text-2xl font-bold text-center">Join us</h3>
          <form action="">
              <div class="mt-4">
                  <div>
                      <label class="block" for="Name">Name</label>
                              <input type="text" placeholder="Name"
                                  class="w-full px-4 py-2 mt-2 border rounded-md focus:outline-none focus:ring-1 focus:ring-blue-600">
                  </div>
                  <!-- <div class="mt-4">
                      <label class="block" for="email">Email</label>
                              <input type="text" placeholder="Email"
                                  class="w-full px-4 py-2 mt-2 border rounded-md focus:outline-none focus:ring-1 focus:ring-blue-600">
                  </div> -->
                  <div class="mt-4">
                      <label class="block">Password</label>
                              <input type="password" placeholder="Password"
                                  class="w-full px-4 py-2 mt-2 border rounded-md focus:outline-none focus:ring-1 focus:ring-blue-600">
                  </div>
                  <div class="mt-4">
                      <label class="block">Confirm Password</label>
                              <input type="password" placeholder="Password"
                                  class="w-full px-4 py-2 mt-2 border rounded-md focus:outline-none focus:ring-1 focus:ring-blue-600">
                  </div>
                  <span class="text-xs text-red-400">Password must be same!</span>
                  <div class="flex">
                      <button class="w-full px-6 py-2 mt-4 text-white bg-teal-500 rounded-lg hover:bg-teal-500">Create
      Account</button>
                  </div>
                  <div class="mt-6 text-grey-dark">
                      Already have an account?
                      <router-link to="/login" class="text-blue-600 hover:underline">Log in</router-link>
                      
                  </div>
              </div>
          </form>
      </div>
  </div>
      <!-- <FooterView /> -->
    </div>
  </template>
  
  <!-- <script>
  import FooterView from "../../components/FooterView.vue";
import HeaderView from "../../components/HeaderView.vue";
  
  // import axios from 'axios'
  // import { onMounted } from 'vue';
  export default {
    name: "RegisterView",
    components: { HeaderView, FooterView },
  };
  </script> -->
  
  <style>
  .logo {
    width: 100px;
  }
  .register input {
    width: 300px;
    height: 40px;
    padding-left: 20px;
    display: block;
    margin-bottom: 30px;
    margin-right: auto;
    margin-left: auto;
    border: 1px solid skyblue;
  }
  .register button {
    width: 320px;
    height: 40px;
    border: 1px solid skyblue;
    background: skyblue;
    color: #fff;
    cursor: pointer;
  }
  </style>
  