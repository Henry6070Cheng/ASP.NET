<template>
  <div>
    <p>{{ message }}</p>
    <p>{{ reversedMessage }}</p>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
const message = ref('Hello, Vue 3')
const reversedMessage = computed(() => {
  return message.value.split('').reverse().join('')
})
</script>

