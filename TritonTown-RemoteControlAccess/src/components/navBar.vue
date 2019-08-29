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
        <ul class="navbar-nav ml-auto">
          <li class="nav-item mx-4">
              <a class="nav-link" @click="goTo('register')">Register</a>
          </li>
          <!-- <li class="nav-item">
            <a class="nav-link" @click="goTo('login')">Sign In<i class="fas fa-user"></i></a>
          </li> -->
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="http://example.com" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            Login
            </a>
            <div class="dropdown-menu dropdown-menu-right" style="padding: 15px; padding-bottom: 10px;">
              <form class="form-horizontal" method="post" accept-charset="UTF-8" @submit.prevent="loginUser">
                  <input class="form-control login" type="text" name="username" placeholder="Username or email.."><br>
                  <input class="form-control login" type="password" name="password" placeholder="Password.."><br>
                  <div class="help-block text-left"><a href="">Forget the password ?</a></div><br>
                  <label><input type="checkbox" checked="checked"> Keep me signed in</label><br>
                  <input class="btn btn-primary" type="submit" name="submit" value="Login">
              </form>
            </div>
          </li>
        </ul>
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

  .dropdown-menu {
    width: 400px;
  }

  .btn-primary {
    background-color: #12284c;
    border-color: black;
  }

  .nav-link {
    cursor: pointer;
  }
</style>