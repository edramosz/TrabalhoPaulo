<template>
  <div>
    <Navbar />
    <RouterView />
    <Footer />
  </div>
</template>

<script>
import Navbar from '@/components/Navbar.vue'
import Footer from '@/components/Footer.vue'
import Post from '@/components/JogoCrud/Post.vue'
export default{
  name: 'App',
  components:{
    Navbar,
    Footer,
    Post
  }
}
</script>
<style>
*{
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}
</style>