<template>
  <form @submit="DeleteItem">
    <input type="text" id="Id" placeholder="Id" v-model="id" />
    <button type="submit">Envie</button>
    </form>
</template>

<script>
export default{
  name: 'Delete',
  return:{
    id: ''
  },
  methods:{
    async DeleteItem(event) {
      event.preventDefault();
      const ResponseDeleteId = this.id

      const response = await fetch(
          `https://localhost:7091/Jogo/Remover-Jogo?id=${ResponseDeleteId}`,
          {
            method: "DELETE",
            headers: { "Content-Type": "application/json" }
          }
        );
  
        if (response.ok) {
    console.log('Requisição bem-sucedida');
  } else {
    console.error('Erro na requisição', response.status, await response.text());
  }
        console.log(response.status);
      },
    },
  };
</script>
<style scoped>

</style>