<template>
  <img :src="imageUrl" alt="Vue logo">
</template>

<script setup>
import { ref } from 'vue'
const imageUrl = ref('https://vuejs.org/images/logo.png')
</script>

