<template>
  <div>
    <p>{{ message }}</p>
    <p>{{ reversedMessage }}</p>
    <p>{{ getReversedMessage() }}</p>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
const message = ref('Hello, Vue 3')
const reversedMessage = computed(() => {
  return message.value.split('').reverse().join('')
})
function getReversedMessage(){
  return message.value.split('').reverse().join('')
}
</script>
