<template>
    <li class="flex justify-between items-center px-8 py-14">
        <div class=" w-2/3">
            <p class=" mb-10 text-xl font-medium text-BlackColor">{{ Comment }}</p>
            <h3 class=" text-2xl font-semibold text-BlackColor mb-2">{{ Name }}</h3>
            <span class=" text-base font-medium text-BlackColor">{{Gmail}}</span>
        </div>
        <div class=" w-1/3">
            <img class="w-full" :src="Url" alt="">
        </div>
    </li>
</template>
<script>
export default{
    data(){
        return{

        }
    },
    props :{
        Name : String,
        Gmail : String,
        Comment : String,
        Url : String
    },
    
}
</script>

<style scoped></style>