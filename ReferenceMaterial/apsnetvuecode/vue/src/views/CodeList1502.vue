

<script>
import { onMounted } from 'vue'
import axios from 'axios'

export default {
  setup() {
    onMounted(() => {
      axios
        .get('https://localhost:7183/Users')
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
