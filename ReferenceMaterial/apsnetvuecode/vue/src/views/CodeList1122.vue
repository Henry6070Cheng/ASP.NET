<template>
  <div>
    <input type="text" ref="inputRef">
    <button @click="focusInput">Focus Input</button>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const inputRef = ref(null)
function focusInput() {
  inputRef.value.focus();
}
</script>

