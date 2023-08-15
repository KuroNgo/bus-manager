<script>
import { RouterLink } from 'vue-router';
</script>
<template>
    <header class="bg-white">
        <nav class="mx-auto flex max-w-7xl items-center justify-between p-6 lg:px-8 " aria-label="Global">
            <div class="flex lg:flex-1">
                <a href="#" class="-m-1.5 p-1.5">
                    <span class="sr-only">Your Company</span>
                    <img class="h-8 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600" alt="">
                </a>
            </div>
            <div class="flex lg:hidden">
                <button type="button" class="-m-2.5 inline-flex items-center justify-center rounded-md p-2.5 text-gray-700">
                    <span class="sr-only">Open main menu</span>
                    <svg class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor"
                        aria-hidden="true">
                        <path stroke-linecap="round" stroke-linejoin="round"
                            d="M3.75 6.75h16.5M3.75 12h16.5m-16.5 5.25h16.5" />
                    </svg>
                </button>
            </div>
            <div class="hidden lg:flex lg:gap-x-12">

                <RouterLink to="/" class=" text-xl font-semibold leading-6 text-gray-900">Home</RouterLink>
                <RouterLink to="/about" class=" text-xl font-semibold leading-6 text-gray-900">About</RouterLink>
                <a href="#" class=" text-xl font-semibold leading-6 text-gray-900">Contact</a>
                <a href="#" class=" text-xl font-semibold leading-6 text-gray-900">Blog</a>
            </div>
            <div class="hidden lg:flex lg:flex-1 lg:justify-end">
                <a href="#" class="text-xl font-semibold leading-6 text-gray-900">Log in <span
                        aria-hidden="true">&rarr;</span></a>
            </div>
        </nav>
        <!-- Mobile menu, show/hide based on menu open state. -->
        <div class="lg:hidden" role="dialog" aria-modal="true">

            <div class="fixed inset-0 z-10"></div>
            <div
                class="fixed inset-y-0 right-0 z-10 w-full overflow-y-auto bg-white px-6 py-6 sm:max-w-sm sm:ring-1 sm:ring-gray-900/10">
                <div class="flex items-center justify-between">
                    <a href="#" class="-m-1.5 p-1.5">
                        <span class="sr-only">Your Company</span>
                        <img class="h-8 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600"
                            alt="">
                    </a>
                    <button type="button" class="-m-2.5 rounded-md p-2.5 text-gray-700">
                        <span class="sr-only">Close menu</span>
                        <svg class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor"
                            aria-hidden="true">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M6 18L18 6M6 6l12 12" />
                        </svg>
                    </button>
                </div>
                <div class="mt-6 flow-root">
                    <div class="-my-6 divide-y divide-gray-500/10">
                        <div class="space-y-2 py-6">                     
                            <div class="">
                                <RouterLink class="-mx-3 block rounded-lg text-5xl px-3 py-2.5 font-semibold leading-7 text-gray-900 hover:bg-gray-50" to="/">Home</RouterLink>
                            </div>                          
                            <div class="">
                                <RouterLink class="-mx-3 block rounded-lg text-5xl px-3 py-2.5 font-semibold leading-7 text-gray-900 hover:bg-gray-50" to="/about">About</RouterLink>
                            </div>
                            <div class="">
                                <RouterLink class="-mx-3 block rounded-lg text-5xl px-3 py-2.5 font-semibold leading-7 text-gray-900 hover:bg-gray-50" to="/contact">Contact</RouterLink>
                            </div>
                            <div class="">
                                <a href="#" class="-mx-3 block rounded-lg text-5xl px-3 py-2.5 font-semibold leading-7 text-gray-900 hover:bg-gray-50">Login</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
</template>
<style>

header{
    border-bottom: 0.1px solid  ;
}

</style>