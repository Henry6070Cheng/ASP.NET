<!-- HelloWorld.vue -->
<template>
  <div>
    <h1>{{ message }}</h1>
    <button @click="changeMessage">Change Message</button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      message: 'Hello, Vue 3!',
    };
  },
  methods: {
    changeMessage() {
      this.message = 'Hello, Single File Component!';
    },
  },
};
</script>

<style>
h1 {
  color: #42b983;
}
</style>
