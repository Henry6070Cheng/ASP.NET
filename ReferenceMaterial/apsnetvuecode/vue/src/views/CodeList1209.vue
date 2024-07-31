<template>
  <div>
    <ChildComponent @button-clicked="handleButtonClicked" />
  </div>
</template>

<script setup>
import ChildComponent from './CodeList1208.vue'
function handleButtonClicked(messageFromChild) {
  console.log('Button clicked in child component with message:', messageFromChild);
}
</script>
