<!-- 在模板中使用router-link组件 -->
<template>
  <div>
    <router-link :to="{ name: 'Home' }">Home</router-link>
    <router-link :to="{ name: 'About' }">About</router-link>
    <router-link :to="{ name: 'User', params: { userId: 123 } }">User 123</router-link>
  </div>
</template>
