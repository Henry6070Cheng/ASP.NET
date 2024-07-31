import { createRouter, createWebHistory } from 'vue-router'
import Dashboard from '../views/components/Dashboard.vue';
import DashboardHeader from '../views/components/DashboardHeader.vue';
import DashboardSidebar from '../views/components/DashboardSidebar.vue';

const isUserLoggedIn = true

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Home',
      component: () => import('../views/components/Home.vue')
    },
    {
      path: '/dashboard',
      name: 'Dashboard',
      component: () => import('../views/components/Dashboard.vue')
    },
    {
      path: '/about',
      name: 'About',
      component: () => import('../views/components/About.vue')
    },
    {
      path: '/user/:userId',
      name: 'User',
      component: () => import('../views/components/User.vue')
    },
    {
      path: '/CodeList1001',
      name: 'CodeList1001',
      component: () => import('../views/CodeList1001.vue')
    },
    {
      path: '/CodeList1002',
      name: 'CodeList1002',
      component: () => import('../views/CodeList1002.vue')
    },
    {
      path: '/CodeList1003',
      name: 'CodeList1003',
      component: () => import('../views/CodeList1003.vue')
    },
    {
      path: '/CodeList1004',
      name: 'CodeList1004',
      component: () => import('../views/CodeList1004.vue')
    },
    {
      path: '/CodeList1013',
      name: 'CodeList1013',
      component: () => import('../views/CodeList1013.vue')
    },
    {
      path: '/CodeList1014',
      name: 'CodeList1014',
      component: () => import('../views/CodeList1014.vue')
    },
    {
      path: '/CodeList1101',
      name: 'CodeList1101',
      component: () => import('../views/CodeList1101.vue')
    },
    {
      path: '/CodeList1102',
      name: 'CodeList1102',
      component: () => import('../views/CodeList1102.vue')
    },
    {
      path: '/CodeList1103',
      name: 'CodeList1103',
      component: () => import('../views/CodeList1103.vue')
    },
    {
      path: '/CodeList1104',
      name: 'CodeList1104',
      component: () => import('../views/CodeList1104.vue')
    },
    {
      path: '/CodeList1105',
      name: 'CodeList1105',
      component: () => import('../views/CodeList1105.vue')
    },
    {
      path: '/CodeList1106',
      name: 'CodeList1106',
      component: () => import('../views/CodeList1106.vue')
    },
    {
      path: '/CodeList1107',
      name: 'CodeList1107',
      component: () => import('../views/CodeList1107.vue')
    },
    {
      path: '/CodeList1108',
      name: 'CodeList1108',
      component: () => import('../views/CodeList1108.vue')
    },
    {
      path: '/CodeList1110',
      name: 'CodeList1110',
      component: () => import('../views/CodeList1110.vue')
    },
    {
      path: '/CodeList1111',
      name: 'CodeList1111',
      component: () => import('../views/CodeList1111.vue')
    },
    {
      path: '/CodeList1113',
      name: 'CodeList1113',
      component: () => import('../views/CodeList1113.vue')
    },
    {
      path: '/CodeList1115',
      name: 'CodeList1115',
      component: () => import('../views/CodeList1115.vue')
    },
    {
      path: '/CodeList1116',
      name: 'CodeList1116',
      component: () => import('../views/CodeList1116.vue')
    },
    {
      path: '/CodeList1117',
      name: 'CodeList1117',
      component: () => import('../views/CodeList1117.vue')
    },
    {
      path: '/CodeList1120',
      name: 'CodeList1120',
      component: () => import('../views/CodeList1120.vue')
    },
    {
      path: '/CodeList1122',
      name: 'CodeList1122',
      component: () => import('../views/CodeList1122.vue')
    },
    {
      path: '/CodeList1123',
      name: 'CodeList1123',
      component: () => import('../views/CodeList1123.vue')
    },
    {
      path: '/CodeList1201',
      name: 'CodeList1201',
      component: () => import('../views/CodeList1201.vue')
    },
    {
      path: '/CodeList1204',
      name: 'CodeList1204',
      component: () => import('../views/CodeList1204.vue')
    },
    {
      path: '/CodeList1207',
      name: 'CodeList1207',
      component: () => import('../views/CodeList1207.vue')
    },
    {
      path: '/CodeList1209',
      name: 'CodeList1209',
      component: () => import('../views/CodeList1209.vue')
    },
    {
      path: '/CodeList1211',
      name: 'CodeList1211',
      component: () => import('../views/CodeList1211.vue')
    },
    {
      path: '/CodeList1213',
      name: 'CodeList1213',
      component: () => import('../views/CodeList1213.vue')
    },
    {
      path: '/CodeList1215',
      name: 'CodeList1215',
      component: () => import('../views/CodeList1215.vue')
    },
    {
      path: '/CodeList1218',
      name: 'CodeList1218',
      component: () => import('../views/CodeList1218.vue')
    },
    {
      path: '/CodeList1220',
      name: 'CodeList1220',
      component: () => import('../views/CodeList1220.vue')
    },/*代码清单13-4*/
    {
      path: '/CodeList1305/:userId',
      name: 'CodeList1305',
      component: () => import('../views/CodeList1305.vue')
    },/*代码清单13-7*/
    {
      path: '/CodeList1308',
      name: 'CodeList1308',
      component: () => import('../views/CodeList1308.vue'),
      children: [
        { path: '', component: () => import('../views/components/Overview.vue') }, // 默认子页面为Overview
        { path: 'orders', component: () => import('../views/components/Orders.vue') },
        { path: 'settings', component: () => import('../views/components/Settings.vue') }
      ]  
    },
    {
      path: '/CodeList1309',
      name: 'CodeList1309',
      component: () => import('../views/CodeList1309.vue')
    },
    {
      path: '/CodeList1310',
      name: 'CodeList1310',
      component: () => import('../views/CodeList1310.vue')
    },
    {
      path: '/CodeList1314',
      name: 'CodeList1314',
      component: () => import('../views/CodeList1314.vue')
    },
    {
      path: '/CodeList1315',
      name: 'CodeList1315',
      component: () => import('../views/CodeList1315.vue')
    },
    {
      path: '/CodeList1317',
      name: 'CodeList1317',
      component: () => import('../views/CodeList1317.vue'),
      children: [{ 
          path: '', 
          components: {
            default: Dashboard,
            header: DashboardHeader,
            sidebar: DashboardSidebar
        }}]  
    },/*代码清单13-18*/
    {
      path: '/CodeList1318',
      name: 'CodeList1318',
      redirect: '/dashboard'
    },/*代码清单13-19*/
    {
      path: '/CodeList1319',
      name: 'CodeList1319',
      redirect: (to) => {
        if (isUserLoggedIn) {
          return '/dashboard';
        } else {
          return '/home';
        }
      }
    },
    {
      path: '/CodeList1322/:id',
      name: 'CodeList1322',
      component: () => import('../views/CodeList1322.vue')
    },
    {
      path: '/CodeList1323',
      name: 'CodeList1323',
      component: () => import('../views/CodeList1323.vue')
    },
    {
      path: '/CodeList1403',
      name: 'CodeList1403',
      component: () => import('../views/CodeList1403.vue')
    },
    {
      path: '/CodeList1502',
      name: 'CodeList1502',
      component: () => import('../views/CodeList1502.vue')
    },
    {
      path: '/CodeList1503',
      name: 'CodeList1503',
      component: () => import('../views/CodeList1503.vue')
    },
    {
      path: '/CodeList1504',
      name: 'CodeList1504',
      component: () => import('../views/CodeList1504.vue')
    },
    {
      path: '/CodeList1505',
      name: 'CodeList1505',
      component: () => import('../views/CodeList1505.vue')
    },
    {
      path: '/CodeList1506',
      name: 'CodeList1506',
      component: () => import('../views/CodeList1506.vue')
    },
    {
      path: '/CodeList1507',
      name: 'CodeList1507',
      component: () => import('../views/CodeList1507.vue')
    }
  ]
})

export default router
