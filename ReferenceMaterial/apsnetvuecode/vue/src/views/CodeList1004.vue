<template>
  <div>
    <h1>{{ message }}</h1>
  </div>
</template>

<script setup>
import { ref,onMounted } from 'vue'

const message = ref('Hello, Vue 3!')

onMounted(() => {
  console.log(`组件挂载完成后！`)
})
</script>

