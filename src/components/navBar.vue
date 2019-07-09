<template>
  <div class="navBar">
    <nav class="navbar navbar-expand-lg navbar-color navbar-dark">
      <a class="navbar-brand" @click="goTo('home')"><img class="crest" src="../assets/crest.png" alt=""></a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
        aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNavDropdown">
        <ul class="navbar-nav d-flex">
          <navLink></navLink>
          <!-- <li class="nav-item mx-4">
            <a class="nav-link" @click="goTo('home')" :class="[current == 'home' ? 'active' : '']">Home</a>
          </li>
          <li class=" nav-item mx-4">
            <a class="nav-link" @click="goTo('get-started')" :class="[current == 'get-started' ? 'active' : '']">Get
              Started</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">Tutorial for Beginners</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">Advanced Examples</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link" @click="goTo('FAQ')">FAQ</a>
          </li> -->

        </ul>
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link">Sign In <i class="fas fa-user"></i></a>
          </li>
        </ul>
      </div>
    </nav>
  </div>
  <!-- <span class="sr-only">(current)</span> -->
</template>

<script>
  import navLink from '@/components/navLink.vue'
  import router from '../router'
  export default {
    name: "navBar",
    props: [],
    data() {
      return {

      }
    },
    computed: {},
    methods: {


    },
    components: {
      navLink
    }
  }
</script>
<style>
  .navbar-color {
    background-color: #12284c;
  }

  #navbarNavDropdown {
    color: white;
  }

  .navbar-toggler {
    color: white;
  }

  .crest {
    max-height: 55px;
    cursor: pointer;
    /* border-radius: 40%; */
  }

  .nav-link {
    cursor: pointer;
  }
</style>