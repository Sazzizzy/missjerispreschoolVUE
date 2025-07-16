<!-- sass miss-jeris-preschool\src\style.scss 
miss-jeris-preschool\src\style.css -->
<script setup>
import Calendar from './MyCalendar.vue';
</script>

<template>
  <div class="colorBlockBlue">
    <div class="contentHeaders">
      A preschool for you!
    </div>
    <p>
       Alphabet based curriculum with music, movement, crafts, healthy snacks, storytime, romping, laughing, poetry, love, joy, and delight.!
    </p>
        <router-link class="mybutton" to="/sign-up">Sign Up Now!</router-link>
  </div>
    <div class="aboutmesection">
        <img class="portrait" src="../assets/Jeri.jpg" alt="Picture of Miss Jeri">
        <div class="aboutme"> <!--about me section-->
        <div class="contentHeaders">About Miss Jeri</div>
        <div>I have my BA in Elementary Education and 8+ Years experience teaching preschool.</div>
    </div>
</div>
</template>

