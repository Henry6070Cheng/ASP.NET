<template>
  <div>
    <!-- 子组件模板内容 -->
    <p>Received data from parent: {{ dataItem }}</p>
    <button @click="callSharedMethod">Click me</button>
  </div>
</template>

<script setup>
import { inject } from 'vue'

const { dataItem, sharedMethod } = inject('location')

function callSharedMethod() {
    sharedMethod();
}
</script>
