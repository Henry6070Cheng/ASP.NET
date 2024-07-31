

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
      instance
        .get('/users')
        .then((response) => {
          console.log('get')
          console.log(response.data)
        })
        .catch((error) => {
          console.error(error)
        })

      instance
        .post('/users', { name: 'John Doe', email: 'john@example.com' })
        .then((response) => {
          console.log('post')
          console.log(response.data)
        })
        .catch((error) => {
          console.error(error)
        })
    })
  }
}
</script>
