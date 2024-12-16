<template>
  <div>
  <h1 class="page-title">Deletar Jogos</h1>
  <form @submit="DeleteItem">
    <input type="text" id="Id" placeholder="Id" v-model="id" />
    <button type="submit">Envie</button>
    </form>
  </div>
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
/* Estilo global para o body para centralizar o conteúdo */
body {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  margin: 0;
  background-color: #f4f4f9; /* Cor de fundo suave */
}

/* Estilo para o título da página */
.page-title {
  color: #333;
  text-align: center;
  font-size: 2rem;
  margin-bottom: 20px;
}

/* Estilo do formulário de deletação */
form {
  background-color: #fff;
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  width: 300px;
  display: flex;
  flex-direction: column;
  gap: 15px;
}

/* Estilo para o campo de input */
input[type="text"] {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 1rem;
  width: 100%;
  box-sizing: border-box;
}

input[type="text"]:focus {
  border-color: #f93e3e; /* Borda vermelha ao focar no campo */
  outline: none;
}

/* Estilo para o botão de deletar */
button {
  padding: 10px;
  background-color: #f93e3e; /* Cor vermelha para a ação de deletar */
  border: none;
  border-radius: 4px;
  color: #fff;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

button:hover {
  background-color: rgb(167, 44, 30); /* Cor mais escura ao passar o mouse */
}

/* Efeito de transição nos campos de entrada */
input[type="text"]:hover {
  border-color: #f93e3e;
}

</style>