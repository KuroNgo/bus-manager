<template>
    <li class="w-full p-4 border border-BlackColor rounded-xl">
        <div class="img ">
            <!-- <img class="w-full" src="../assets/buslogo.png" alt=""> -->
        </div>
        <div class="w-full flex flex-col gap-y-5 pb-5">
            <span class=" text-xl font-medium text-BlackColor">Bus Route {{ route }}</span>
            <h4 class=" text-xl font-bold text-BlackColor">{{ tenTuyen }}</h4>
            <span class=" text-xl font-medium text-BlackColor">Operating hours: {{ thoiGianBatDau }} AM – {{ thoiGianKetThuc }}
                PM</span>
            <span class=" text-base font-medium text-BlackColor">Spacing: {{ thoiGianKhoangCach }}</span>
        </div>
    </li>
</template>
    
<script>
import axios from 'axios'
export default {
    data() {
        return {

        }
    },
    props: {
        route: String,
        tenTuyen: String,
        thoiGianBatDau: String,
        thoiGianKetThuc: String,
        thoiGianKhoangCach: String,
    }

}
</script>
    
<style scoped>
.img{    
    user-select: none;
    cursor: pointer;
    width: auto;
    height: 240px;
    background: url(../../../public/assets/img/ux-city-bus-rafiki-1.png) no-repeat center/cover;
}
</style>




