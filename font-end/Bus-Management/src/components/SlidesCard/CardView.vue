<template>
    <li class="w-full p-4 relative border border-BlackColor rounded-xl">
        <div class="img ">
            <!-- <img class="w-full" src="../assets/buslogo.png" alt=""> -->
        </div>
        <div class="w-full flex flex-col gap-y-5 pb-5">
            <span class=" text-xl font-medium text-BlackColor">Bus Route {{ route }}</span>
            <h4 class=" text-xl font-bold text-BlackColor">{{ tenTuyen }}</h4>
            <span class=" text-xl font-medium text-BlackColor">Operating hours: {{ thoiGianBatDau }} AM – {{ thoiGianKetThuc
            }}
                PM</span>
            <span class=" text-base font-medium text-BlackColor">Spacing: {{ thoiGianKhoangCach }}</span>
            <button @click="showDesrc =! showDesrc">Xem chi tiết</button>
        </div>
        <div v-if="showDesrc" class=" flex  p-4 flex-col gap-y-5 absolute bottom-0 left-0 right-0 bg-SecondColor rounded-xl" style="height:90%;">
            <div class=" w-1/2 flex justify-between items-center">
                <span class=" text-xl font-medium text-BlackColor">Bus Route {{ route }}</span>
                <font-awesome-icon @click="showDesrc =! showDesrc" icon="fa-solid fa-arrow-down" class=" text-2xl" style="color: #1749a1;" />
            </div>
            <h4 class=" text-xl font-bold text-BlackColor">{{ tenTuyen }}</h4>
            <span class=" text-xl font-medium text-BlackColor">Operating hours: {{ thoiGianBatDau }} AM – {{ thoiGianKetThuc
            }}
                PM</span>
            <span class=" text-base font-medium text-BlackColor">Spacing: {{ thoiGianKhoangCach }}</span>
            <span class=" text-base font-medium text-BlackColor">Lộ trình xe :</span>
            <span class=" text-base font-medium text-BlackColor">{{ loTrinhLuotDi }}</span>
            <!-- <span class=" text-base font-medium text-BlackColor">{{ loTrinhLuotVe }}</span> -->
        </div>
    </li>
</template>
    
<script>
import axios from 'axios'
export default {
    data() {
        return {
            showDesrc : false
        }
    },
    props: {
        route: String,
        tenTuyen: String,
        thoiGianBatDau: String,
        thoiGianKetThuc: String,
        thoiGianKhoangCach: String,
        loTrinhLuotDi:String,
        loTrinhLuotVe:String
    },
    methods: {
        testnhe() {
            alert('xin chào')
        }
    }

}
</script>
    
<style scoped>
.img {
    user-select: none;
    cursor: pointer;
    width: auto;
    height: 240px;
    background: url(../../../public/assets/img/ux-city-bus-rafiki-1.png) no-repeat center/cover;
}
</style>




