<template>
  <div class="About">
    <!-- If you want to highlight hardcoded source-code -->
    <pre v-highlightjs="sourcecode"><code class="python"></code></pre>
  </div>
</template>

<script>
export default {
  name: "About",
  props: [],
  data() {
    return {
      sourcecode: "class test():"
    };
  },
  computed: {},
  methods: {},
  components: {}
};
</script>

