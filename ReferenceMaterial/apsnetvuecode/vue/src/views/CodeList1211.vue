<template>
  <div>
   <p>Value in parent component: {{ inputValue }}</p>
    <CustomInput v-model="inputValue" />
  </div>
</template>

<script setup>
import { ref } from 'vue'
import CustomInput from './CodeList1210.vue'
const inputValue = ref('')
</script>
