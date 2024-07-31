import './assets/main.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
// 代码清单13-2
import router from './router'

const app = createApp(App)

app.use(createPinia())
app.use(router)

app.mount('#app')
