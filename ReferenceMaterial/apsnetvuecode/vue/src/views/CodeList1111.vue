<template>
  <div>
    <p v-if="showMessage">Hello, Vue 3!</p>
    <p v-else>Click the button to show the message.</p>
    <button @click="toggleMessage">Toggle Message</button>
  </div>

</template>

<script setup>
import { ref } from 'vue'
const showMessage = ref(false)
function toggleMessage() {
  showMessage.value = !showMessage.value
}
</script>

