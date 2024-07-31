<template>
  <div>
    <button @click="handleClick">Click me</button>
  </div>
</template>

<script setup>
const emit = defineEmits(['button-clicked'])

function handleClick() {
  emit('button-clicked');
}
</script>
