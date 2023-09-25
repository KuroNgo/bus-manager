<template>
  <GoogleMap :api-key="apiKey" :map-id="mapId" class="w-full h-screen" :center="center" :zoom="15">
    <Marker v-for="marker in markers" :options="{ position: marker, icon: this.icon }" />
  </GoogleMap>
</template>
    
<script>
import { defineComponent } from "vue";
import { GoogleMap, Marker } from "vue3-google-map";
import { RepositoryFactory } from '../API/RepositoryFactory';
const TuyenRepository = RepositoryFactory.get('tuyen')


export default defineComponent({
  components: {
    GoogleMap, Marker
  },
  data() {
    return {
      apiKey: 'AIzaSyDftopPEaLPsiVP5YLYsrNyxLuIt6gIvHM',
      center: { lat: 11.94646, lng: 108.44193 },
      markers: null,
      mapId: "e2b94e7ad9ef6d87",
      icon: {
        url: '../../public/assets/img/busmarker.png',
        scaledSize: { width: 50, height: 50 }
      },
    }
  },
  props: {
    locationInp: String,
  },
  methods: {
    async TuyenAPI() {

      const response = await TuyenRepository.getTuyen('1.0');
      const dataAll = response.data.data
      return dataAll.map(item => item.loTrinhLuotDi);

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
        case 'tuyendalat–ductrong':
          return tuyensData[0].split(/ – |- /)

        case 'tuyendalat–donduong':
          return tuyensData[1].split(/ – |- /)

        case 'tuyendalat–lacduong':
          return tuyensData[2].split(/ – |- /)

        case 'tuyendalat–baoloc':
          return tuyensData[3].split(/ – |- /)

        case 'tuyendalat–xuantruong':
          return tuyensData[4].split(/ – |- /)

        case 'tuyendalat–phuson':
          return tuyensData[5].split(/ – |- /)

        case 'tuyenliennghia–tamthanh':
          return tuyensData[6].split(/ – |- /)

        case 'tuyendalat–sanbaylienkhuong':
          return tuyensData[7].split(/ – |- /)

        case 'tuyendalat–dailao':
          return tuyensData[8].split(/ – |- /)

        case 'tuyenliennghia–tanthanh':
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
      // const marker = await this.getLatAndLng(tuyen)
      const markerPromises = tuyen.map(element => {
        const addressWithSuffix = element + ' Đà lạt Lâm Đồng ';
        return this.GoogleMapAPI(addressWithSuffix);
      });

      const markers = await Promise.all(markerPromises);
      this.markers = markers
    }

  },
  created() {
    this.GoogleMapAPI()
    this.TuyenAPI()
  },

});
</script>
    
<style scoped>

</style>
  