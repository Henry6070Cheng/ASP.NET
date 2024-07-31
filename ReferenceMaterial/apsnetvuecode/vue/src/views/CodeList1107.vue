<template>
  <div>
    <p><button @click="showMessage('Welcome to Vue 3!')">Show Message</button></p>
  </div>
</template>

<script setup>
function showMessage(message) {
  alert(message);
}
</script>