

<script>
import { onMounted } from 'vue'
import axios from 'axios'
// 创建axios实例
const instance = axios.create({
  baseURL: 'https://localhost:7183',
  timeout: 5000,
  headers: {
    'Content-Type': 'application/json',
    Authorization: 'Bearer your_access_token'
  }
})

export default {
  setup() {
    onMounted(() => {
      // 使用实例发送请求
      instance
        .get('/Users')
        .then((response) => {
          console.log(response.data)
        })
        .catch((error) => {
          console.error(error)
        })
    })
  }
}
</script>
