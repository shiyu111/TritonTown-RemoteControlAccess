<template>
  <div class="navBar">
    <nav class="navbar navbar-expand-lg navbar-color navbar-dark">
      <a class="navbar-brand"><img class="crest" src="../assets/crest.png" alt=""></a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
        aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNavDropdown">
        <ul class="navbar-nav d-flex">
          <li class="nav-item active mx-4">
            <a class="nav-link">Home <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">Get Started</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">Tutorial for Beginners</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">Advanced Examples</a>
          </li>
          <li class="nav-item mx-4">
            <a class="nav-link">FAQ</a>
          </li>
        </ul>
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link">Sign In <i class="fas fa-user"></i></a>
          </li>
        </ul>
      </div>
    </nav>
  </div>
</template>

<script>
  export default {
    name: "navBar",
    props: [],
    data() {
      return {}
    },
    computed: {},
    methods: {},
    components: {}
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