import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import getStarted from './views/GetStarted.vue'
import FAQ from './views/FAQ.vue'
import Tutorials from './views/Tutorials.vue'
import About from './views/About.vue'
import Login from './views/Login.vue'
import Loginhome from './views/LoginHome.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/get-started',
      name: 'get-started',
      component: getStarted
    },
    {
      path: '/faq',
      name: 'FAQ',
      component: FAQ
    },
    {
      path: '/tutorials',
      name: 'tutorials',
      component: Tutorials
    },
    {
      path: '/about',
      name: 'about',
      component: About
    },
	{
		path: '/login',
		name: 'login',
		component: Login
	},
	{
		path: '/loginhome',
		name: 'loginhome',
		component: Loginhome
	},
  ]
})
