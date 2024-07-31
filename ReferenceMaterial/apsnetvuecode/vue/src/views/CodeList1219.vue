<template>
  <div>
    <!-- 异步组件模板内容 -->
    <p>This is an async component.</p>
  </div>
</template>

<script setup>
// 导入defineAsyncComponent函数
import { defineAsyncComponent } from 'vue';

// 创建异步组件
const AsyncComponent = defineAsyncComponent(() => {
  // 这里返回组件的import函数，用于延迟加载组件
  return import('./CodeList1219.vue');
});
</script>
