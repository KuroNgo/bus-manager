
<template>

    <header class=" bg-MainColor px-28 sticky top-0 left-0 right-0 z-50">

        <nav class="flex items-center">
            <div class="flex items-center text-xl font-medium text-BlackColor ">
                <img src="../../public/assets/img/buslogo.png" class="w-24" alt="">
                <h1>Bus Management</h1>
            </div>

            <div class="flex gap-x-8 mx-auto ">
                <RouterLink to="/" class=" text-xl font-medium text-BlackColor">Home</RouterLink>
                <RouterLink to="/about" class=" text-xl font-medium text-BlackColor">About</RouterLink>
                <RouterLink to="/service" class=" text-xl font-medium text-BlackColor">Service</RouterLink>
                <RouterLink to="/contact" class=" text-xl font-medium text-BlackColor">Contact</RouterLink>
            </div>

            <div class="flex gap-3">
                <RouterLink to="/login"><button tag="li" class=" px-2 py-2 w-36 rounded-xl bg-ThirdColor text-base font-medium text-FourColor">Sign in</button></RouterLink>
                <RouterLink to='/register'><button tag="li" class=" px-2 py-2 w-36 rounded-xl bg-FourColor text-base font-medium text-MainColor">Sign Up</button></RouterLink>
            </div>

        </nav>
    </header>
</template>

<script>
import { RouterLink } from 'vue-router';
export default {
    
}
</script>

<style scoped>


</style>