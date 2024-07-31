<template>
  <div>
    <p><button v-on:click="sayHello">Say Hello</button></p>
  </div>
</template>

<script setup>
function sayHello() {
  alert('Hello, Vue 3!');
}
</script>
