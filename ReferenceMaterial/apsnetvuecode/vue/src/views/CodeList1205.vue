<template>
  <div>
    <p>{{ message }}</p>
  </div>
</template>

<script setup>
const props = defineProps({
message: {
      type: String, // 类型为字符串
      required: true, // 必需的属性
      default: 'Default Message', // 默认值
      validator(value) {
      // 自定义验证函数
        return String(value).length <= 10
      }
    }
})
</script>
