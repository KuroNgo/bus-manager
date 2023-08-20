
<template>
    <header class="bg-transparent drop-shadow-md fixed top-0 left-0 right-0" :class="{ scrolled: isScrolled }">
        <nav class="mx-auto flex items-center justify-between py-10 px-32">
            <div class="">
                <span class="text-xl  font-semibold leading-6 text-slate-100 mr-40">Logo</span>
            </div>
            <div class="flex gap-x-6">
                <RouterLink to="/" class=" text-xl font-semibold leading-6 text-slate-100">Home</RouterLink>
                <RouterLink to="/about" class=" text-xl font-semibold leading-6 text-slate-100">About</RouterLink>
                <RouterLink to="/contact" class=" text-xl font-semibold leading-6 text-slate-100">Contact</RouterLink>
            </div>
            <div class="flex flex-1 justify-end gap-x-7">
                <button tag="li" class="text-xl font-semibold leading-6 text-slate-100 ">Login</button>
                <button tag="li" class="text-xl font-semibold leading-6 text-slate-100 bnt rounded-3xl px-16 py-4">Sign Up</button>
            </div>
        </nav>
    </header>
</template>

<script>
import { RouterLink, RouterView } from 'vue-router';
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
nav {
    max-width: 95%;
}

header {
    transition: background-color 0.3s;
}

header.scrolled {
    background: rgb(56, 40, 91);
    background: linear-gradient(45deg, rgba(56, 40, 91, 0.7819502801120448) 0%, rgba(30, 18, 80, 1) 98%);

}

.bnt {
    background: rgb(51, 148, 196);
    background: linear-gradient(180deg, rgba(51, 148, 196, 0.896796218487395) 47%, rgba(89, 197, 194, 0.7679446778711485) 81%);

}
.bnt:hover {
  background: rgb(63, 94, 251);
  background: radial-gradient(circle, rgba(63, 94, 251, 1) 0%, rgba(252, 70, 107, 1) 100%);

}

li:hover,
li:active {
  background-color: indianred;
  cursor: pointer;
}
</style>