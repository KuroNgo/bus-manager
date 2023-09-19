<template>
   <main class="flex">
      <div class="">
         <button data-drawer-target="default-sidebar" data-drawer-toggle="default-sidebar" aria-controls="default-sidebar"
            type="button"
            class="inline-flex items-center p-2 mt-2 ml-3 text-sm text-gray-500 rounded-lg sm:hidden hover:bg-gray-100 focus:outline-none focus:ring-2 focus:ring-gray-200 dark:text-gray-400 dark:hover:bg-gray-700 dark:focus:ring-gray-600">
            <span class="sr-only">Open sidebar</span>
            <svg class="w-6 h-6" aria-hidden="true" fill="currentColor" viewBox="0 0 20 20"
               xmlns="http://www.w3.org/2000/svg">
               <path clip-rule="evenodd" fill-rule="evenodd"
                  d="M2 4.75A.75.75 0 012.75 4h14.5a.75.75 0 010 1.5H2.75A.75.75 0 012 4.75zm0 10.5a.75.75 0 01.75-.75h7.5a.75.75 0 010 1.5h-7.5a.75.75 0 01-.75-.75zM2 10a.75.75 0 01.75-.75h14.5a.75.75 0 010 1.5H2.75A.75.75 0 012 10z">
               </path>
            </svg>
         </button>

         <aside id="logo-sidebar"
            class="w-64 h-screen pt-14 transition-transform -translate-x-full bg-white border-r border-gray-200 sm:translate-x-0 dark:bg-gray-800 dark:border-gray-700"
            aria-label="Sidebar">
            <div class="h-full px-3 pb-4 pt-4 overflow-y-auto bg-white dark:bg-gray-800">
               <ul class="space-y-2 font-medium">
                  <input type="text" v-model="location" name="" id="">
                  <button @click="getLotrinh1">Tìm Kiếm</button>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                        <span class="ml-3">Dashboard</span>
                     </a>
                     <ul class="space-y-2 font-medium " v-for="x in test">
                        <li>
                           <a href="#"
                              class="flex items-center  text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                              <span class="ml-3">{{ x }}</span>
                           </a>
                        </li>
                     </ul>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                        <span class="flex-1 ml-3 whitespace-nowrap">Kanban</span>
                        <span
                           class="inline-flex items-center justify-center px-2 ml-3 text-sm font-medium text-gray-800 bg-gray-100 rounded-full dark:bg-gray-700 dark:text-gray-300">Pro</span>
                     </a>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">

                        <span class="flex-1 ml-3 whitespace-nowrap">Inbox</span>
                        <span
                           class="inline-flex items-center justify-center w-3 h-3 p-3 ml-3 text-sm font-medium text-blue-800 bg-blue-100 rounded-full dark:bg-blue-900 dark:text-blue-300">3</span>
                     </a>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">

                        <span class="flex-1 ml-3 whitespace-nowrap">Users</span>
                     </a>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">

                        <span class="flex-1 ml-3 whitespace-nowrap">Products</span>
                     </a>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">

                        <span class="flex-1 ml-3 whitespace-nowrap">Sign In</span>
                     </a>
                  </li>
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">

                        <span class="flex-1 ml-3 whitespace-nowrap">Sign Up</span>
                     </a>
                  </li>
               </ul>
            </div>


         </aside>
      </div>
      <MapView :locationInp="location" :dataTuyenAPI="dataTuyenAPI" />
   </main>
</template>
<script>
import MapView from './MapView.vue';
import { RepositoryFactory } from '../API/RepositoryFactory';
import { useCounterStore } from '../stores/counter'
const TuyenRepository = RepositoryFactory.get('tuyen')

export default {
   components: {
      MapView
   },
   data() {
      return {
         location: '',
         dataTuyen: null,
         tenTuyen: [],
         test: null,
         dataTuyenAPI: null,
      }
   },
   methods: {
      async getLotrinh1() {
         const response = await TuyenRepository.getTuyen('1.0');
         this.dataTuyen = response.data.data
         for (let i = 0; i < this.dataTuyen.length; i++) {
            this.tenTuyen.push(this.dataTuyen[i].tenTuyen)
         }
         console.log(this.dataTuyen[0])

         const searchTerm = this.location;
         const json = this.dataTuyen
         // Tìm các tuyến có lộ trình lượt đi chứa searchTerm
         const matchingRoutes = json.filter(tuyen => {
            const loTrinh = tuyen.loTrinhLuotDi.toLowerCase();
            return loTrinh.includes(searchTerm.toLowerCase());
         });

         // Lấy tên và tên tuyến của các tuyến tìm thấy hoặc thông báo nếu không có tuyến nào
         const ketQua = matchingRoutes.map(tuyen => {
            return  tuyen.tenTuyen
         });
         this.test = ketQua
         console.log(`Các tuyến chứa "${searchTerm}":`);
         console.log(ketQua);
      }
      // async TuyenAPI() {
      //    var dataLoTrinh = []
      //    const response = await TuyenRepository.getTuyen('1.0');
      //    const dataAll = response.data.data
      //    for (let i = 0; i < dataAll.length; i++) {
      //       dataLoTrinh.push(dataAll[i].loTrinhLuotDi)
      //    }
      //    this.dataTuyenAPI = dataLoTrinh

      //    // console.log(dataLoTrinh)
      // },
   },
   created() {
      // this.getLotrinh1()
   }
}
</script>
<style scoped></style>

