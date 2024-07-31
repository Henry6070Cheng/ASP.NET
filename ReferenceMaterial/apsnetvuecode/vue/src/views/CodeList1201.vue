<template>
  <div>
  </div>
</template>

<script>
import {
 onMounted,
 onBeforeMount,
 onBeforeUpdate,
 onUpdated,
} from "vue"

export default {
 setup() {
   console.log("1-开始创建组件-----setup()")
 
   onBeforeMount(() => {
     console.log("2-组件挂载到页面之前执行-----onBeforeMount()")
   });

   onMounted(() => {
     console.log("3-组件挂载到页面之后执行-----onMounted()")
   });

   onBeforeUpdate(() => {
     console.log("4-组件更新之前-----onBeforeUpdate()")
   });

   onUpdated(() => {
     console.log("5-组件更新之后-----onUpdated()")
   })
 }
}
</script>
