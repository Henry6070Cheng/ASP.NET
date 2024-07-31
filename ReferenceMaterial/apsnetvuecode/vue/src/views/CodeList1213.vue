<template>
  <div>
    <CustomButton class="custom-button" @click="handleButtonClick" title="Click me" />
  </div>
</template>

<script setup>
import CustomButton from './CodeList1212.vue'
function handleButtonClick() {
  console.log('Button clicked in parent component');
}
</script>
