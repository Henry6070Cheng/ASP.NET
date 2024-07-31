<template>
  <div>
    <button @click="goToHome()">Home</button>
    <button @click="goToAbout()">About</button>
    <button @click="goToUser()">User 123</button>
  </div>
</template>

<script>
export default {
  methods: {
    goToHome() {
      // 编程式导航到name为home的路由配置
      this.$router.push({ name: 'Home' });
    },
    goToAbout() {
      // 编程式导航到name为about的路由配置
      this.$router.push({ name: 'About' });
    },
    goToUser() {
      // 编程式导航到name为user的路由配置，并传递参数
      this.$router.push({ name: 'User', params: { userId: 123 } });
    }
  }
}
</script>

<style scoped>
h2 {
  color: red;
}
</style>