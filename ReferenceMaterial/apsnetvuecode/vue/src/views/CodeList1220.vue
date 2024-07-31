<template>
  <div>
    <!-- 应用程序模板内容 -->
    <button @click="showAsyncComponent">Show Async Component</button>
    <div v-if="showComponent">
      <async-component />
    </div>
  </div>
</template>

<script setup>
import {ref} from 'vue'
import AsyncComponent from './CodeList1219.vue';

const showComponent = ref(false)

function showAsyncComponent() {
      showComponent.value = true;
}
</script>
