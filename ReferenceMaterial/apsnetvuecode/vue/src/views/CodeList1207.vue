<template>
  <div>
    <ChildComponent @button-clicked="handleButtonClicked" />
  </div>
</template>

<script setup>
import ChildComponent from './CodeList1206.vue'
function handleButtonClicked() {
      console.log('Button clicked in child component');
}
</script>
