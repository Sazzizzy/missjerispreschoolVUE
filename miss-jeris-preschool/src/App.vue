<!-- 
<template>
  <body>
    <div><Headercomp/></div>
    <!-- <div class="img-slider"></div> 
    <div class="contentbg">
      <div class="content"><Content/></div>
    </div>
  </body>
</template>
 -->
<template>
    <router-view/>
</template>


<script setup>
import { ref } from 'vue';
const count = ref(0);
</script>