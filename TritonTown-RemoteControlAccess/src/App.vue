<template>
  <div id="app" class="container-fluid">
    <div class="row">
      <div class="col">
        <img class="img-fluid my-3" src="./assets/logo.png" alt="">
      </div>
    </div>
    <!-- <banner></banner> -->
    <div class="row">
      <div class="col">
        <navBar></navBar>
      </div>
    </div>
    <!-- <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link> -->

    <router-view />
  </div>
</template>
<script>
  import navBar from "@/components/navBar.vue"
  export default {
    name: "app",
    props: [],
    data() {
      return {}
    },
    computed: {},
    methods: {},
    components: {
      navBar,
    }
  }
</script>
<style>
  #app {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

  /* #nav {
    padding: 30px;
  } */

  #nav a {
    font-weight: bold;
    color: #2c3e50;
  }

  #nav a.router-link-exact-active {
    color: #42b983;
  }
</style>