<template>
  <div>
    <h1>Welcome To CodeList1317</h1>

    <!-- 这里是Dashboard的导航栏 -->
    <router-view name="header"></router-view>

    <!-- 这里是Dashboard的内容区域 -->
    <router-view></router-view>

    <!-- 这里是Dashboard的侧边栏 -->
    <router-view name="sidebar"></router-view>
  </div>
</template>

