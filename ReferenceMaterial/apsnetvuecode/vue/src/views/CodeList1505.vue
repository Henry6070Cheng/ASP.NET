

<script>
import { onMounted } from 'vue'
import axios from 'axios'

const config = {
  headers: {
    'Content-Type': 'application/json',
    Authorization: 'Bearer your_access_token'
  }
}

export default {
  setup() {
    onMounted(() => {
      axios
        .post('https://localhost:7183/Users', { name: 'value' }, config)
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
