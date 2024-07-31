<!-- 代码清单13-3 -->
<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>
<template>
  <div class="menu-wrapper">
    <nav>
      <router-link to="/CodeList1001">代码清单10-1</router-link>
      <router-link to="/CodeList1002">代码清单10-2</router-link>
      <router-link to="/CodeList1003">代码清单10-3</router-link>
      <router-link to="/CodeList1004">代码清单10-4</router-link>
      <router-link to="/CodeList1013">代码清单10-13</router-link>
      <router-link to="/CodeList1014">代码清单10-14</router-link>
      <router-link to="/CodeList1101">代码清单11-1</router-link>
      <router-link to="/CodeList1102">代码清单11-2</router-link>
      <router-link to="/CodeList1103">代码清单11-3</router-link>
      <router-link to="/CodeList1104">代码清单11-4</router-link>
      <router-link to="/CodeList1105">代码清单11-5</router-link>
      <router-link to="/CodeList1106">代码清单11-6</router-link>
      <router-link to="/CodeList1107">代码清单11-7</router-link>
      <router-link to="/CodeList1108">代码清单11-8</router-link>
      <router-link to="/CodeList1110">代码清单11-10</router-link>
      <router-link to="/CodeList1111">代码清单11-11</router-link>
      <router-link to="/CodeList1113">代码清单11-13</router-link>
      <router-link to="/CodeList1115">代码清单11-15</router-link>
      <router-link to="/CodeList1116">代码清单11-16</router-link>
      <router-link to="/CodeList1117">代码清单11-17</router-link>
      <router-link to="/CodeList1120">代码清单11-20</router-link>
      <router-link to="/CodeList1122">代码清单11-22</router-link>
      <router-link to="/CodeList1123">代码清单11-23</router-link>
      <router-link to="/CodeList1201">代码清单12-1</router-link>
      <router-link to="/CodeList1204">代码清单12-4</router-link>
      <router-link to="/CodeList1207">代码清单12-7</router-link>
      <router-link to="/CodeList1209">代码清单12-9</router-link>
      <router-link to="/CodeList1211">代码清单12-11</router-link>
      <router-link to="/CodeList1213">代码清单12-13</router-link>
      <router-link to="/CodeList1215">代码清单12-15</router-link>
      <router-link to="/CodeList1218">代码清单12-18</router-link>
      <router-link to="/CodeList1220">代码清单12-20</router-link>
      <router-link to="/CodeList1305/tim">代码清单13-5</router-link>
      <router-link to="/CodeList1308">代码清单13-8</router-link>
      <router-link to="/CodeList1309">代码清单13-9</router-link>
      <router-link to="/CodeList1310">代码清单13-10</router-link>
      <router-link to="/CodeList1314">代码清单13-14</router-link>
      <router-link to="/CodeList1315">代码清单13-15</router-link>
      <router-link to="/CodeList1317">代码清单13-17</router-link>
      <router-link to="/CodeList1318">代码清单13-18</router-link>
      <router-link to="/CodeList1319">代码清单13-19</router-link>
      <router-link to="/CodeList1322/123">代码清单13-22</router-link>
      <router-link :to="{ path: '/CodeList1323', query: { id: 123, category: 'electronics' } }">代码清单13-23</router-link>
      <router-link to="/CodeList1403">代码清单14-3</router-link>
      <router-link to="/CodeList1502">代码清单15-2</router-link>
      <router-link to="/CodeList1503">代码清单15-3</router-link>
      <router-link to="/CodeList1504">代码清单15-4</router-link>
      <router-link to="/CodeList1505">代码清单15-5</router-link>
      <router-link to="/CodeList1506">代码清单15-6</router-link>
      <router-link to="/CodeList1507">代码清单15-7</router-link>
    </nav>
  </div>
  <div class="content-wrapper">
    <router-view />
  </div>
</template>

<style scoped>
.menu-wrapper {
  background-color: rgb(230, 225, 226);
  min-height: 600px;
}
.content-wrapper {
  background-color: rgb(245, 245, 250);
  min-width: 800px;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  nav {
    text-align: left;
    font-size: 1rem;

    padding: 1rem 0;
  }
}
</style>
