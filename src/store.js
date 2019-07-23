import Vue from 'vue'
import Vuex from 'vuex'
import navBarLinks from './stores/navBarLinks'
import Axios from 'axios'
import router from './router'

Vue.use(Vuex)

let baseUrl = location.host.includes('localhost') ? '//localhost:5000/' : '/'

let auth = Axios.create({
  baseURL: baseUrl + "account/",
  timeout: 3000,
  withCredentials: true
})

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
})

export default new Vuex.Store({
  state: {
    user: {}
  },
  modules: {
    navBarLinks
  },
  mutations: {
    setUser(state, user) {
      state.user = user
    }
  },
  actions: {
    //#region AUTH
    register({ commit, dispatch }, newUser) {
      // debugger
      console.log(newUser)
      auth.post('register', newUser)
        .then(res => {
          commit('setUser', res.data)
          router.push({ name: 'home' })
        })
        .catch(e => {
          console.log('[registration failed] :', e)
        })
    },

    authenticate({ commit, dispatch }) {
      auth.get('authenticate')
        .then(res => {
          commit('setUser', res.data)
          // router.push({ name: 'home' })
          dispatch('getPublicKeeps')
          dispatch('getPersonalKeeps')
          dispatch('getVaults')
        })
        .catch(e => {
          console.log('not authenticated')
        })
    },

    login({ commit, dispatch }, creds) {
      auth.post('login', creds)
        .then(res => {
          commit('setUser', res.data)
          router.push({ name: 'home' })
        })
        .catch(e => {
          console.log('Login Failed')
        })
    }
  }
})
