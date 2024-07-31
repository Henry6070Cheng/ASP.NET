

<script>
import { onMounted } from 'vue'
import axios from 'axios'

export default {
  setup() {
    onMounted(() => {
      // 要提交的数据
      const formData = {
        name: 'John Doe',
        email: 'john@example.com'
      }

      axios
        .post('https://localhost:7183/Users', formData)
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
