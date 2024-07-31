<template>
  <div>
    <card>
      <template v-slot:header>
        <h2>Title</h2>
      </template>

      <p>This is the main content of the card.</p>

      <template v-slot:footer>
        <button>Click me</button>
      </template>
    </card>
  </div>
</template>

<script setup>
import Card from './CodeList1214.vue'
</script>
