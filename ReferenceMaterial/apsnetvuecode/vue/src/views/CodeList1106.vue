<template>
  <div>
    <p><button @click="sayHello">Say Hello</button></p>
  </div>
</template>

<script setup>
function sayHello() {
  alert('Hello, Vue 3!');
}
</script>
