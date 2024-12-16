import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home,
    },
    {
      path: '/post',
      name: 'PostView',
      component: () => import('../views/JogoView/PostView.vue'),
    },
    {
      path: '/delete',
      name: 'DeleteView',
      component: () => import('../views/JogoView/DeleteView.vue'),
    },
    {
      path: '/put',
      name: 'PutView',
      component: () => import('../views/JogoView/PutView.vue'),
    },
    {
      path: '/get',
      name: 'GetView',
      component: () => import('../views/JogoView/GetView.vue'),
    },
    {
      path: '/Carrinho',
      name: 'Carrinho',
      component: () => import('../views/Carrinho.vue'),
    },
  ],
})

export default router
