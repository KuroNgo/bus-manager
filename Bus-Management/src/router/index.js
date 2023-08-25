import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import FooterView from '../components/FooterView.vue'
import HeaderView from '../components/HeaderView.vue'


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Home | Bus Management',
      component: HomeView
    },
    {
      path: '/about',
      name: 'About | Bus Management',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/AboutView.vue')
    },
    {
      path: '/contact',
      name: 'Contact | Bus Management',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/ContactView.vue')
    },
    {
      path: "/:pathMatch(.*)*",
      name:"OPPS | Page Not Found",
      component: () => import('../views/NotfoundView.vue'),
    },
    {
      name: 'resgister',
      component: ()=>import('../views/Client/RegisterView.vue'),
      path: '/register',
    },
    {
      name: 'login',
      component: ()=>import('../views/Client/LoginView.vue'),
      path: '/login',
    },
  ]
})

export default router
