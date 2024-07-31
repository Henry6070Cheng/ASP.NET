<template>
  <div>
    <!-- 父组件模板内容 -->
    <slot></slot>
  </div>
</template>

<script setup>
import { ref, provide } from 'vue'
const dataItem = ref('This is a shared data item')

function sharedMethod() {
  console.log('This is a shared method')
}

provide('location', {
  dataItem,
  sharedMethod
})
</script>
