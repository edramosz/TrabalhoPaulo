<template>
    <div id="navbar">
        <ul>
        <RouterLink to="/get"><li>GET</li></RouterLink>
        <RouterLink to="post"><li>POST</li></RouterLink>
        <RouterLink to="delete"><li>DELETE</li></RouterLink>
        <RouterLink to="put"><li>PUT</li></RouterLink>
        </ul>
    </div>
</template>

<script>
export default{
name: 'Navbar'
}
</script>
<style scoped>

#navbar{
    background-color: rgb(77, 79, 80);
    
}

ul{
    display: flex;
    list-style: none;
}
li{
    text-decoration: none;
    margin-left: 100px;
    align-content: end;
}
</style>