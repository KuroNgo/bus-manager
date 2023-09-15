import * as vueRouter from 'vue-router';
import HomeView from '../views/HomeView.vue';
const  routes = [
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
      component: ()=>import('../views/Client/RegisterView.vue'),
      path: '/register',
    },
    {
      name: 'login',
      component: ()=>import('../views/Client/LoginView.vue'),
      path: '/login',
    },
    {
      path: "/:pathMatch(.*)*",
      name:"OPPS | Page Not Found",
      component: () => import('../views/NotfoundView.vue'),
      
    },
    {
      name: 'admin',
      component: () => import('../views/Admin/ViewAdmin.vue'),
      path: '/admin',
    },
    {
      name: 'donviquanlyxe',
      component: () => import('../views/Admin/DonViQLXe.vue'),
      path: '/DVQLX',
    },
    {
      name: 'drivermanager',
      component: () => import('../views/Admin/DriverManager.vue'),
      path: '/drivermanager',
    },
    {
      name: 'car',
      component: () => import('../views/Admin/CarManager.vue'),
      path: '/car',
    },
    {
      name: 'street',
      component: () => import('../views/Admin/Street.vue'),
      path: '/street',
    },
  ];
  const router = vueRouter.createRouter({
    history: vueRouter.createWebHistory(),
    routes: routes,
  });
  
  router.beforeEach((to, from, next) => {
    console.log(to)
    document.title=` ${ to.name } `
    next()
  })
export default router
