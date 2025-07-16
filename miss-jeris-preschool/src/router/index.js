import { createRouter, createWebHistory } from 'vue-router'
import MainLayout from '../components/MainLayout.vue';
import Home from '../components/Home.vue';
import SignUp from '../components/SignUp.vue';

const routes = [
    {
        path: '/',
        component: MainLayout, 
        children: [
            { path: '', name: 'home', component: Home },
            { path: 'sign-up', name: 'sign-up', component: SignUp},
        ]
    }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router