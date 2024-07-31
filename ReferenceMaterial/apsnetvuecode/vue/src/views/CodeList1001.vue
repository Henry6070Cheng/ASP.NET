<template>
  <div>
    <h2>{{ count }}</h2>
    <button @click="count++">Click me</button>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const count = ref(0)
</script>

<style scoped>
h2 {
  color: red;
}
</style>
