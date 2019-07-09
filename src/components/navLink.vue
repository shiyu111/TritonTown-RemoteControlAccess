<template>
  <div class="navLink">
    <li v-for="page in pages" class="nav-item mx-4">
      <a class="nav-link" @click="goTo(page.pathName)"
        :class="[current == page.pathName ? 'active' : '']">{{page.displayName}}</a>
    </li>
  </div>

</template>

<script>
  import router from '../router'

  export default {
    name: "navLink",
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
    components: {}
  }
</script>
<style>
  /* .active {
    color: #fff
  } */
</style>