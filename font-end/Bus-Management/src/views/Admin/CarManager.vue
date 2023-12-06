<template>
  <div>
    <link
      rel="stylesheet"
      href="https://unpkg.com/boxicons@2.0.7/css/boxicons.min.css"
    />

    <div class="min-h-screen flex flex-row bg-white">
      <div class="flex flex-col w-56 bg-white rounded-r-3xl">
        <div class="flex items-center justify-center h-20">
          <div class="flex items-center justify-center h-20">
            <img src="/assets/img/buslogo.png" alt="Logo" class="h-full" />
          </div>
        </div>
        <ul class="flex flex-col py-4">
          <li>
            <a
              href="#"
              class="flex flex-row items-center h-12 transform hover:translate-x-2 transition-transform ease-in duration-200 text-gray-500 hover:text-gray-800"
            >
              <span
                class="inline-flex items-center justify-center h-12 w-12 text-lg text-gray-400"
                ><i class="bx bx-home"></i
              ></span>
              <span class="text-sm font-medium">Tuyến xe</span>
            </a>
          </li>
          <li>
            <a
              href="#"
              class="flex flex-row items-center h-12 transform hover:translate-x-2 transition-transform ease-in duration-200 text-gray-500 hover:text-gray-800"
            >
              <span
                class="inline-flex items-center justify-center h-12 w-12 text-lg text-gray-400"
                ><i class="bx bx-car"></i
              ></span>
              <span class="text-sm font-medium">Xe</span>
            </a>
          </li>
          <li></li>
          <li>
            <a
              href="#"
              class="flex flex-row items-center h-12 transform hover:translate-x-2 transition-transform ease-in duration-200 text-gray-500 hover:text-gray-800"
            >
              <span
                class="inline-flex items-center justify-center h-12 w-12 text-lg text-gray-400"
                ><i class="bx bx-shopping-bag"></i
              ></span>
              <span class="text-sm font-medium">Đơn vị quản lý xe</span>
            </a>
          </li>

          <li>
            <a
              href="#"
              class="flex flex-row items-center h-12 transform hover:translate-x-2 transition-transform ease-in duration-200 text-gray-500 hover:text-gray-800"
            >
              <span
                class="inline-flex items-center justify-center h-12 w-12 text-lg text-gray-400"
                ><i class="bx bx-user"></i
              ></span>
              <span class="text-sm font-medium">Tài xế</span>
            </a>
          </li>

          <li>
            <a
              href="#"
              class="flex flex-row items-center h-12 transform hover:translate-x-2 transition-transform ease-in duration-200 text-gray-500 hover:text-gray-800"
            >
              <span
                class="inline-flex items-center justify-center h-12 w-12 text-lg text-gray-400"
                ><i class="bx bx-log-out"></i
              ></span>
              <span class="text-sm font-medium">Logout</span>
            </a>
          </li>
        </ul>
      </div>
      <div class="flex-grow bg-white">
        <table class="min-w-full divide-y divide-gray-200">
          <thead class="bg-white divide-y divide-gray-200">
            <tr class="bg-white divide-y divide-gray-200"></tr>
            <tr>
              <th
                class="px-200 py-3 text-centre text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
              License plates
              </th>
              <th
                class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
                Type Car
              </th>
              <th
                class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
              Wattage
              </th>
             
              <th
                class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
              Date of manufacture
              </th>
              <th
                class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
                ID route street
              </th>
              <th
                class="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
              >
               Action
              </th>
            </tr>
          </thead>
          <tbody class="bg-white divide-y divide-gray-200">
            <tr>
              <td class="px-6 py-4 whitespace-nowrap">49-a 123</td>
              <td class="px-6 py-4 whitespace-nowrap">Bus</td>
              <td class="px-6 py-4 whitespace-nowrap">Hight</td>
              <td class="px-6 py-4 whitespace-nowrap">17/2/2202</td>
              <td class="px-6 py-4 whitespace-nowrap">09</td>
              <td class="px-6 py-4 whitespace-nowrap">
                <button
                  class="px-4 py-2 font-medium text-white bg-blue-600 rounded-md hover:bg-blue-500 focus:outline-none focus:shadow-outline-blue active:bg-blue-600 transition duration-150 ease-in-out"
                >
                  Edit
                </button>
                <button
                  class="ml-2 px-4 py-2 font-medium text-white bg-red-600 rounded-md hover:bg-red-500 focus:outline-none focus:shadow-outline-red active:bg-red-600 transition duration-150 ease-in-out"
                >
                  Delete
                </button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style scope>
tr {
  height: 80px;
}
img.h-full {
  width: 230px;
}
</style>
