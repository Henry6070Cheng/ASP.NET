<template>
  <div>
    <p><button @click="changeImageUrl">Change Image</button></p>
  	<p><img :src="imageUrl" alt="Vue logo"></p>
  </div>
</template>

<script setup>
import { ref } from 'vue'
const imageUrl = ref('https://vuejs.org/images/logo.png')
function changeImageUrl() {
  imageUrl.value = 'https://cn.vuejs.org/assets/sponsor-placement-1.25fabbfe.png'
}
</script>

