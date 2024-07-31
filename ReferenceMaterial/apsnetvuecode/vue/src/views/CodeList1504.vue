

<script>
import { onMounted } from 'vue'
import axios from 'axios'

export default {
  setup() {
    onMounted(() => {
      // 要提交的数据
      const updatedData = {
        name: 'Updated Name',
        email: 'updated@example.com'
      }

      axios
        .put('https://localhost:7183/Users/1', updatedData)
        .then((response) => {
          // 请求成功，处理返回的数据
          console.log(response.data)
        })
        .catch((error) => {
          // 请求失败，处理错误
          console.error(error)
        })
    })
  }
}
</script>
