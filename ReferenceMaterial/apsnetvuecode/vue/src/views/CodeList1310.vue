<template>
  <div>
    <button @click="goToHome()">Home</button>
    <button @click="goToAbout()">About</button>
  </div>
</template>

<script>
export default {
  methods: {
    goToHome() {
      // 编程式导航到Home页面
      this.$router.push('/');
    },
    goToAbout() {
      // 编程式导航到About页面
      this.$router.push('/about');
    }
  }
}
</script>

<style scoped>
h2 {
  color: red;
}
</style>
