<template>
  <div>
    <p v-if="showMessage">{{ message }}</p>
    <button @click="toggleMessage">Toggle Message</button>
  </div>
</template>

<script setup>
import { ref } from 'vue'

const message = ref('Hello, Vue 3!')
const showMessage = ref(true)

function toggleMessage(event) {
  showMessage.value = !showMessage.value
}
</script>
