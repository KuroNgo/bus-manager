<template>
  <GoogleMap :api-key="apiKey" :map-id="mapId" class="w-full h-screen" :center="center" :zoom="15">
    <Marker v-for="marker in markers" :options="{ position: marker }" />
  </GoogleMap>

  <!-- <button @click="getLocation(getLotrinh(convertToNoDiacriticAndTrim()))">Tìm kiém</button> -->
  <button @click="run">Tìm kiém</button>
</template>
    
<script>
import { defineComponent } from "vue";
import { GoogleMap, Marker } from "vue3-google-map";
import { RepositoryFactory } from '../API/RepositoryFactory';
import { useCounterStore } from '../stores/counter'

const TuyenRepository = RepositoryFactory.get('tuyen')


export default defineComponent({
  components: {
    GoogleMap, Marker
  },
  data() {
    return {
      apiKey: 'AIzaSyBo_dMvKTL2pzB8VkXsQUsUQgsA81rTrxI',
      center: { lat: 11.94646, lng: 108.44193 },
      markers: null,
      mapId: "af9302bb516bbe98",
    };
  },
  props: {
    locationInp: String,
    dataTuyenAPI: Array
  },
  methods: {
    async TuyenAPI() {
      var dataLoTrinh = []
      const response = await TuyenRepository.getTuyen('1.0');
      const dataAll = response.data.data
      for (let i = 0; i < dataAll.length; i++) {
        dataLoTrinh.push(dataAll[i].loTrinhLuotDi)
      }
      return dataLoTrinh
    },
    // Get Google Map API
    async GoogleMapAPI(address) {
      const keyApi = this.apiKey
      try {
        const response = await fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${address}&key=${keyApi}`);

        const jsonData = await response.json();

        if (jsonData.results.length > 0) {

          const location = jsonData.results[0].geometry.location;

          if (typeof location.lat === 'number' && typeof location.lng === 'number' && isFinite(location.lat) && isFinite(location.lng)) {

            return location;

          } else {
            console.log("Tọa độ không hợp lệ.");
          }
        } else {
          // console.log("Không tìm thấy tọa độ cho địa chỉ này.");
        }
      } catch (error) {
        console.log(error);
      }
    },
    convertToNoDiacriticAndTrimTest() {
      // Chuyển chuỗi thành chữ thường và loại bỏ khoảng trắng
      const normalizedString = this.locationInp.toLowerCase().replace(/\s+/g, '');

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
      const result = normalizedString
        .split('')
        .map(char => diacriticMap[char] || char)
        .join('');

      return result;
    },
    async ConvertStringToArray(string, tuyensData) {
      // const tuyensData = await this.TuyenAPI()
      switch (string) {
        case 'ductrong':
          return tuyensData[0].split(/ – |- /)

        case 'donduong':
          return tuyensData[1].split(/ – |- /)

        case 'lacduong':
          return tuyensData[2].split(/ – |- /)

        case 'baoloc':
          return tuyensData[3].split(/ – |- /)

        case 'xuantruong':
          return tuyensData[4].split(/ – |- /)

        case 'phuson':
          return tuyensData[5].split(/ – |- /)

        case 'tamthanh':
          return tuyensData[6].split(/ – |- /)

        case 'sanbaylienkhuong':
          return tuyensData[7].split(/ – |- /)

        case 'dailao':
          return tuyensData[8].split(/ – |- /)

        case 'tamthanh':
          return tuyensData[9].split(/ – |- /)

        default:
          break;
      }
    },

    // Get Lat and Lng from address
    async getLatAndLng(array) {
      var location = []
      for (let i = 0; i < array.length; i++) {
        const element = array[i] + ' Đà lạt Lâm Đồng ';
        const result = await this.GoogleMapAPI(element)
        location.push(result)
      }
      return location
    },
    async run() {
      this.markerTest = []
      const dataTuyenAPI = await this.TuyenAPI()
      const address = this.convertToNoDiacriticAndTrimTest()
      const tuyen = await this.ConvertStringToArray(address, dataTuyenAPI)
      const marker = await this.getLatAndLng(tuyen)
      this.markers = marker
    }

  },
  created() {
    this.GoogleMapAPI()
    this.TuyenAPI()
  },
  computed: {
    // getMarkerOptions() {
    //   return {
    //     position: this.center,
    //     label: "L",
    //     title: "LADY LIBERTY",
    //   };
    // },
  }

});
</script>
    
<style scoped></style>
  