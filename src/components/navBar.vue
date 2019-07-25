<template>
  <div class="navBar">
    <nav class="navbar navbar-expand-lg navbar-color navbar-dark">
      <a class="navbar-brand" @click="goTo('home')"><img class="crest" src="../assets/picture_logo.png" alt=""></a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
        aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNavDropdown">
        <ul class="navbar-nav d-flex">
          <!-- iterates over navlinks  -->
          <li v-for="page in pages" class="nav-item mx-4">
            <a class="nav-link" @click="goTo(page.pathName)"
              :class="[current == page.pathName ? 'active' : '']">{{page.displayName}}</a>
          </li>
        </ul>
				
<!--        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-login" @click="router.push(login)">Sign In <i class="fas fa-user"></i></a>
          </li>
        </ul> -->
      </div>
    </nav>
  </div>
</template>

<script>
  import router from '../router'
  export default {
    name: "navBar",
    props: [],
    data() {
      return {
        current: ''

      }
    },
    computed: {
      pages() {
        return this.$store.state.navBarLinks.pages
      }
    },
    methods: {
      goTo(page) {
        router.push({ name: page })
        this.current = page
      }

    },
    components: {
    }
  }
</script>
<style>
  .navbar-color {
    background-color: #00649C;
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