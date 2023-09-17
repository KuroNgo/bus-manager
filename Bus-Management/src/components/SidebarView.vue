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
            <div class="h-full px-3 pb-4 overflow-y-auto bg-white dark:bg-gray-800">
               <ul class="space-y-2 font-medium">
                  <input type="text" v-model="location" name="" id="">
                  <li>
                     <a href="#"
                        class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                        <span class="ml-3">Dashboard</span>
                     </a>
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
      <MapView :locationInp="location" />
   </main>
</template>
<script>
import MapView from './MapView.vue';
export default {
   components: {
      MapView
   },
   data() {
      return {
         location: '',
      }
   },
   methods: {
      convertToNoDiacriticAndTrim() {
         // Chuyển chuỗi thành chữ thường và loại bỏ khoảng trắng
         const normalizedString = this.location1.toLowerCase().replace(/\s+/g, '');

         // Bảng ký tự có dấu và không dấu tương ứng
         const diacriticMap = {
            'à': 'a', 'á': 'a', 'ả': 'a', 'ã': 'a', 'ạ': 'a',
            'ă': 'a', 'ắ': 'a', 'ằ': 'a', 'ẳ': 'a', 'ẵ': 'a', 'ặ': 'a',
            'â': 'a', 'ấ': 'a', 'ầ': 'a', 'ẩ': 'a', 'ẫ': 'a', 'ậ': 'a',
            'đ': 'd',
            'è': 'e', 'é': 'e', 'ẻ': 'e', 'ẽ': 'e', 'ẹ': 'e',
            'ê': 'e', 'ế': 'e', 'ề': 'e', 'ể': 'e', 'ễ': 'e', 'ệ': 'e',
            'ì': 'i', 'í': 'i', 'ỉ': 'i', 'ĩ': 'i', 'ị': 'i',
            'ò': 'o', 'ó': 'o', 'ỏ': 'o', 'õ': 'o', 'ọ': 'o',
            'ô': 'o', 'ố': 'o', 'ồ': 'o', 'ổ': 'o', 'ỗ': 'o', 'ộ': 'o',
            'ơ': 'o', 'ớ': 'o', 'ờ': 'o', 'ở': 'o', 'ỡ': 'o', 'ợ': 'o',
            'ù': 'u', 'ú': 'u', 'ủ': 'u', 'ũ': 'u', 'ụ': 'u',
            'ư': 'u', 'ứ': 'u', 'ừ': 'u', 'ử': 'u', 'ữ': 'u', 'ự': 'u',
            'ỳ': 'y', 'ý': 'y', 'ỷ': 'y', 'ỹ': 'y', 'ỵ': 'y',
         };

         // Duyệt qua từng ký tự trong chuỗi và thay thế ký tự có dấu bằng ký tự không dấu
         this.location2 = normalizedString
            .split('')
            .map(char => diacriticMap[char] || char)
            .join('');
         return this.location1;
      },
      test1(){
         this.location = this.convertToNoDiacriticAndTrim(this.location)
         console.log(this.location)
      }
   },

   props: {

   }
}
</script>
<style scoped></style>