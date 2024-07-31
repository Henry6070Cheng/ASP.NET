<template>
  <div>
    <p>Count: {{ count }}</p>
    <button @click="incrementCount">Increment</button>
  </div>
</template>

<script setup>
import { ref,watch } from 'vue'
const count = ref(0)

function incrementCount() {
  count.value++;
}

watch(count, async (newValue, oldValue) => {
  console.log(`Count changed from ${oldValue} to ${newValue}`)
})
</script>

