<template>
  <div>
    <ChildComponent :message="parentMessage" />
  </div>
</template>

<script setup>
import ChildComponent from './CodeList1203.vue'
import { ref } from 'vue'
const parentMessage = ref('Hello from parent component!')
</script>

