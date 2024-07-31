<template>
  <div>
    <p>Count: {{ counter.count }}</p>
    <p>Double Count: {{ counter.doubleCount }}</p>
    <button @click="counter.increment">Increment</button>
    <button @click="counter.reset">Reset</button>
  </div>
</template>

<script>
import { useCounterStore } from './CodeList1402';

export default {
  setup() {
    const counter = useCounterStore();

    return { counter };
  },
};
</script>
