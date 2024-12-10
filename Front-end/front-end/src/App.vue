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
import Post from '@/components/Post.vue'
export default{
  name: 'App',
  components:{
    Navbar,
    Footer,
    Post
  }
}
</script>
