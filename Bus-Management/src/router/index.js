import * as vueRouter from 'vue-router';
import HomeView from '../views/HomeView.vue';
const routes = [
  {
    path: '/',
    name: 'Home | Bus Management',
    component: HomeView
  },
  {
    path: '/service',
    name: 'Service | Bus Management',
    // route level code-splitting
    // this generates a separate chunk (About.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import('../views/ServiceView.vue'),
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
    component: () => import('../views/ContactView.vue'),
  },
  {
    name: 'resgister',
    component: () => import('../views/Client/RegisterView.vue'),
    path: '/register',
  },
  {
    name: 'login',
    component: () => import('../views/Client/LoginView.vue'),
    path: '/login',
  },
  {
    path: "/:pathMatch(.*)*",
    name: "OPPS | Page Not Found",
    component: () => import('../views/NotfoundView.vue'),

  },
];
const router = vueRouter.createRouter({
  history: vueRouter.createWebHistory(),
  routes: routes,

  // Cuộn lên đầu trang khi chuyển Route
  scrollBehavior(to, from, savedPosition) {
    if (to.hash) {
      // Nếu route đích có anchor (ví dụ: #section1)
      return { el: to.hash, behavior: 'smooth' };
    } else if (savedPosition) {
      // Nếu đã lưu vị trí cuộn trước đó
      return savedPosition;
    } else {
      // Mặc định, kéo lên đầu trang
      return { top: 0 };
    }
  },
});

router.beforeEach((to, from, next) => {
  console.log(to)
  document.title = ` ${to.name} `
  next()

})
export default router
