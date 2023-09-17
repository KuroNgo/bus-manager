<template>
    <main class="flex">
      <Sidebar />
      <GoogleMap :api-key="apiKey" :map-id="mapId" class="w-full h-screen" :center="center" :zoom="15">
        <Marker :options="{ position: center }" />
      </GoogleMap>
    </main>
  </template>
    
  <script>
  import { defineComponent } from "vue";
  import { GoogleMap, Marker } from "vue3-google-map";
  import Sidebar from './SidebarView.vue';
  // import axios from 'axios'; // Import Axios
  
  export default defineComponent({
    components: {
      Sidebar,
      GoogleMap, Marker
    },
    data() {
      return {
        apiKey: 'AIzaSyDgMQE6cHwf8gCbMd7N3eTmkjv4QPGn3Ro',
        center: null, // Không cần khởi tạo là { lat: null, lng: null }
        mapId: "af9302bb516bbe98",
        marker: ["Bến xe buýt đường Mai Anh Đào, P8, Đà Lạt"]
      };
    },
    methods: {
      async getLocation() {
        try {
          const keyApi = this.apiKey;
          const address = 'Đà Lạt';
          const response = await fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${address}&key=${keyApi}`);
          const jsonData = await response.json();
          console.log(jsonData);
          if (jsonData.results.length > 0) {
            const location = jsonData.results[0].geometry.location;
            console.log(location); // { lat: 45.425152, lng: -75.6998028 }
  
            // Kiểm tra giá trị lat và lng trước khi gán cho this.center
            if (typeof location.lat === 'number' && typeof location.lng === 'number' && isFinite(location.lat) && isFinite(location.lng)) {
              this.center = location; // Gán trực tiếp location vào this.center
              console.log(this.center.lat);
            } else {
              console.log("Tọa độ không hợp lệ.");
            }
          } else {
            console.log("Không tìm thấy tọa độ cho địa chỉ này.");
          }
        } catch (error) {
          console.log(error);
        }
      }
    },
    created() {
      this.getLocation();
    },
    computed: {
      getMarkerOptions() {
        return {
          position: this.center,
          label: "L",
          title: "LADY LIBERTY",
        };
      },
    }
  
  });
  </script>
    
  <style scoped></style>
  