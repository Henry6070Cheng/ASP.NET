<template>
  <div>
    <label for="username">Username:</label>
    <input type="text" id="username" v-model="username">
    <p>Your username is: {{ username }}</p>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const username = ref('')
</script>
