<template>
  <div>
    <ul>
      <li v-for="(item, index) in items" :key="item.id">{{ index + 1 }}. {{ item.name }}</li>
    </ul>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const items = ref([
  { id: 1, name: 'Item 1' },
  { id: 2, name: 'Item 2' },
  { id: 3, name: 'Item 3' }
])
</script>
