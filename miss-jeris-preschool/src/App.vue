<script setup>
import Headercomp from './components/Headercomp.vue';
import Content from './components/Content.vue'
import Home from './components/Home.vue';
const slides = [
  './assets/slideimages/photo1.jpg',
  './assets/slideimages/photo2.jpg',
  './assets/slideimages/photo3.png',
];
</script>

<template>
  <body>
    <div><Headercomp/></div>
    <!-- <div class="img-slider"></div> -->
    <div class="contentbg">
      <div class="content"><Content/></div>
    </div>
  </body>
</template>



