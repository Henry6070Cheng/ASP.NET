<template>
  <div>
    <button v-bind="$attrs" @click="handleButtonClick">Click me</button>
    <p><span>Fallthrough attribute: {{ $attrs }}</span></p>
  </div>
</template>

<script setup>
defineOptions({
  inheritAttrs: false
})
function handleButtonClick() {
      console.log('Button clicked in children component');
}
</script>
