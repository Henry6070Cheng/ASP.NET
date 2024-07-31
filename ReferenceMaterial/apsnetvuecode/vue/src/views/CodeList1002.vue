<template>
  <div>
    <p>{{ message }}</p>
    <input v-model="message" />
  </div>
</template>

<script setup>
import { ref } from 'vue'
const message = ref('Hello, Vue 3!')
</script>

