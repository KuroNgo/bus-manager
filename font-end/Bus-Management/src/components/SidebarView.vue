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

         <div class="h-full px-3 pb-4 pt-4 overflow-y-auto bg-FourColor">
            <ul class="space-y-2 font-medium">
               <input type="text" class=" p-2 rounded-xl w-full" v-model="location" name="" id="">
               <button @click="Search" class=" block mx-auto rounded-xl bg-ThirdColor w-52 py-2 px-3">Tìm Kiếm</button>
               <li>
                  <a href="#" class="flex items-center p-2 text-gray-900 rounded-lg bg-gray-700 group">
                     <span class="ml-3">Dashboard</span>
                  </a>
                  <ul class=" max-h-44 overflow-auto">
                     <li class="space-y-2 font-medium " v-for="x, i in tenTuyen">
                        <a @click="GetValues(x)"
                           class=" p-2 select-none flex items-center rounded-lg text-MainColor hover:bg-ThirdColor hover:text-FourColor">
                           <font-awesome-icon icon="fa-solid fa-bus-simple" class=" text-BlackColor" />
                           <span :id="i" class="ml-3">{{ x }}</span>
                        </a>
                     </li>
                  </ul>
               </li>
               <li>
                  <a @click="showAll = !showAll"
                     class="flex items-center p-2 rounded-lg dark:text-white bg-gray-700 group">
                     <span class="flex-1 ml-3 whitespace-nowrap">All</span>
                     <span
                        class="inline-flex items-center justify-center px-2 ml-3 text-sm font-medium text-gray-800 bg-gray-100 rounded-full dark:bg-gray-700 dark:text-gray-300">Pro</span>
                  </a>
                  <ul class=" h-96 overflow-auto">
                     <li v-if="showAll" class="space-y-2 font-medium " v-for="x, i in getAll">
                        <div @click="GetValues(x)"
                           class="p-2 select-none flex items-center rounded-lg text-MainColor hover:bg-ThirdColor hover:text-FourColor">
                           <font-awesome-icon icon="fa-solid fa-bus-simple" class=" text-BlackColor" />
                           <span :id="i" class="ml-3">{{ x }}</span>
                        </div>
                     </li>
                  </ul>
               </li>
            </ul>
         </div>


      </div>
      <MapView :locationInp="addresss" ref="mapRun" />
   </main>
</template>
<script>
import MapView from './MapView.vue';
import { RepositoryFactory } from '../API/RepositoryFactory';
const TuyenRepository = RepositoryFactory.get('tuyen')

export default {
   components: {
      MapView
   },
   data() {
      return {
         searchValue: null,
         location: '',
         addresss: '',
         tenTuyen: [],
         getAll: null,
         showAll: false,
         getLoaiTuyenAll: null
      }
   },
   methods: {
      async GetAll() {
         const json = await this.TuyenAPI()
         const ketQua = json.map(tuyen => {
            return tuyen.tenTuyen
         });
         const loaituyen = json.map(loaituyen => {
            return loaituyen.loaiTuyen
         });
         this.getAll = ketQua
         this.getLoaiTuyenAll = loaituyen
      },
      async Search() {
         const searchTerm = this.location;
         const json = await this.TuyenAPI()
         // Tìm các tuyến có lộ trình lượt đi chứa searchTerm
         const matchingRoutes = json.filter(tuyen => {
            const loTrinh = tuyen.loTrinhLuotDi.toLowerCase();
            return loTrinh.includes(searchTerm.toLowerCase());
         });

         // Lấy tên và tên tuyến của các tuyến tìm thấy hoặc thông báo nếu không có tuyến nào
         const ketQua = matchingRoutes.map(tuyen => {
            return tuyen.tenTuyen
         })
         if (ketQua.length == 0) {
            this.tenTuyen = []
            this.tenTuyen.push(`Không tìm thấy ${this.location}`)
         } else {
            this.tenTuyen = []
            this.tenTuyen = ketQua
         }
      },
      GetValues(x) {
         // const valueSpan = x;
         this.addresss = x
         this.$refs.mapRun.run();
      },
      async TuyenAPI() {
         const tenTuyen = []
         const response = await TuyenRepository.getTuyen('1.0');
         const dataTuyen = response.data.data
         for (let i = 0; i < dataTuyen.length; i++) {
            tenTuyen.push(dataTuyen[i].tenTuyen)
         }
         return dataTuyen
      },
      dataHome() {
         this.searchValue = localStorage.getItem('searchValue');
         if (this.searchValue !== '') {
            this.location = this.searchValue
            this.Search()
         } else {
            this.location == ''
         }
      }
   },
   created() {
      this.TuyenAPI()
      this.GetAll()
      this.dataHome()
   }
}
</script>
<style scoped></style>

