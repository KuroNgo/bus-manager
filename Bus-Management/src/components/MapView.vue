<template>
  <GoogleMap :api-key="apiKey" :map-id="mapId" class="w-full h-screen" :center="center" :zoom="15">
    <Marker v-for="marker in markerLat" :options="{ position: marker }" />
  </GoogleMap>

  <button @click="getLocation(getLotrinh(convertToNoDiacriticAndTrim()))">Tìm kiém</button>
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
      apiKey: 'AIzaSyDgMQE6cHwf8gCbMd7N3eTmkjv4QPGn3Ro',
      center: { lat: 11.94646, lng: 108.44193 },
      markerLat: [],
      dataBus: null,
      tuyensData: [],
      tuyenData: null,
      mapId: "af9302bb516bbe98",
      markers: ['đường Đinh Tiên Hoàng Đà Lạt', 'Trường Đại Học Đà Lạt']
    };
  },
  props: {
    locationInp: String
  },
  methods: {
    //Hàm đổi thành chữ không dấu
    convertToNoDiacriticAndTrim() {
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

      return this.getLotrinh(result);
    },
    //Hàm Call API Lộ trình xe buýt
    async getLotrinh(a) {
      this.markerLat = []
      const response = await TuyenRepository.getTuyen('1.0');
      this.dataBus = response.data.data
      for (let i = 0; i < this.dataBus.length; i++) {
        this.tuyensData.push(this.dataBus[i].loTrinhLuotDi)
      }
      switch (a) {
        case 'ductrong':
          this.tuyenData = (this.tuyensData[0].split(/ – |- /))
          break;
        case 'donduong':
          this.tuyenData = (this.tuyensData[1].split(/ – |- /))
          break;
        default:
          break;
      }
      console.log(this.tuyenData)
      return this.getLocation(this.tuyenData)

    },
    //Hàm Call API google Map
    async getLocation(x) {
      try {
        for (let index = 0; index < x.length; index++) {
          const keyApi = this.apiKey;
          const address = x[index] + ' Đà lạt Lâm Đồng ';
          console.log(address)
          const response = await fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${x[index] + ' Đà lạt Lâm Đồng '}&key=${keyApi}`);

          const jsonData = await response.json();


          if (jsonData.results.length > 0) {
            const location = jsonData.results[0].geometry.location;
            // Kiểm tra giá trị lat và lng trước khi gán cho this.center
            if (typeof location.lat === 'number' && typeof location.lng === 'number' && isFinite(location.lat) && isFinite(location.lng)) {

              this.markerLat.push(location); // Gán trực tiếp location vào this.center

            } else {
              console.log("Tọa độ không hợp lệ.");
            }
          } else {
            console.log("Không tìm thấy tọa độ cho địa chỉ này.");
          }
        }

      } catch (error) {
        console.log(error);
      }
    }

  },
  mounted() {


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
  