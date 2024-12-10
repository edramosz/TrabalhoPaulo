import { createRouter, createWebHistory } from 'vue-router'
import Login from '../views/LoginView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'LoginView',
      component: Login,
    },
    {
      path: '/post',
      name: 'PostView',
      component: () => import('../views/PostView.vue'),
    },
    {
      path: '/delete',
      name: 'DeleteView',
      component: () => import('../views/DeleteView.vue'),
    },
    {
      path: '/put',
      name: 'PutView',
      component: () => import('../views/PutView.vue'),
    },
    {
      path: '/get',
      name: 'GetView',
      component: () => import('../views/GetView.vue'),
    },
  ],
})

export default router
