
<template>
    <header class=" bg-MainColor px-28 fixed top-0 left-0 right-0 " :class="{ scrolled: isScrolled }">
        <nav class="flex items-center">
            <div class="flex items-center text-xl font-medium text-BlackColor ">
                <img src="./assets/buslogo.png" class="w-24" alt="">
                <h1>Bus Management</h1>
            </div>

            <div class="flex gap-x-8 mx-auto ">
                <RouterLink to="/" class=" text-xl font-medium text-BlackColor">Home</RouterLink>
                <RouterLink to="/about" class=" text-xl font-medium text-BlackColor">About</RouterLink>
                <RouterLink to="/service" class=" text-xl font-medium text-BlackColor">Service</RouterLink>
                <RouterLink to="/contact" class=" text-xl font-medium text-BlackColor">Contact</RouterLink>
            </div>

            <div class="flex gap-3">
                <button tag="li" class=" px-2 py-2 w-36 rounded-xl bg-ThirdColor text-base font-medium text-FourColor">Sign in</button>
                <button tag="li" class=" px-2 py-2 w-36 rounded-xl bg-FourColor text-base font-medium text-MainColor">Sign Up</button>
            </div>

        </nav>
    </header>
</template>

<script>
import { RouterLink } from 'vue-router';
export default {
    data() {
        return {
            isScrolled: false
        };
    },
    methods: {
        handleScroll() {
            this.isScrolled = window.scrollY > 50;
        }
    },
    mounted() {
        window.addEventListener("scroll", this.handleScroll);
    },
    beforeUnmount() {
        window.removeEventListener("scroll", this.handleScroll);
    }
}
</script>

<style scoped>

header {
    transition: background-color 0.3s;
}

header.scrolled {
    /* background-color: #F5F6FA; */
}

</style>