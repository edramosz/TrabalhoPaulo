<template>
  <div>
    <h1 class="page-title">Editar Jogos</h1>
    <form @submit="PutItem">
      <input type="text" id="Id" placeholder="Id" v-model="id" />
      <input type="text" id="Nome" placeholder="Nome" v-model="nome" />
      <input type="text" id="Tipo" placeholder="Tipo" v-model="tipo" />
      <input type="text" id="Preco" placeholder="Preco" v-model="preco" />
      <input
        type="text"
        id="Descricao"
        placeholder="Descricao"
        v-model="descricao"
      />
      <input type="text" id="Genero" placeholder="Genero" v-model="genero" />
      <input type="text" id="Estoque" placeholder="Estoque" v-model="estoque" />
      <button type="submit">Envie</button>
    </form>
  </div>
  </template>
  
  <script>
  export default {
    name: "Put",
    data() {
      return {
        nome: "",
        tipo: "",
        preco: "",
        descricao: "",
        genero: "",
        estoque: "",
      };
    },
    methods: {
      async PutItem(event) {
        event.preventDefault(); // Previne o comportamento de envio do formulário
        // Agora você pode fazer a requisição PUT
        const data = {
          id: this.id,
          tipo: this.tipo,
          nome: this.nome,
          preco: this.preco,
          descricao: this.descricao,
          genero: this.genero,
          estoque: this.estoque,
        };
        const dataJson = JSON.stringify(data);
  
        const response = await fetch(
          "https://localhost:7091/Jogo/Editar-Jogo",
          {
            method: "PUT",
            headers: { "Content-Type": "application/json" },
            body: dataJson,
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
  /* Define um estilo básico para o corpo da página */
body {
  font-family: Arial, sans-serif;
  background-color: #f4f4f9;
  margin: 0;
  padding: 0;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
}

/* Estilo para o título da página */
.page-title {
  color: #333;
  text-align: center;
  font-size: 2rem;
  margin-bottom: 20px;
}

/* Estilo para o formulário */
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

/* Estilo para os campos de entrada */
input[type="text"] {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 1rem;
  width: 100%;
  box-sizing: border-box;
}

input[type="text"]:focus {
  border-color: #fca130;
  outline: none;
}

/* Estilo para o botão de envio */
button {
  padding: 10px;
  background-color: #fca130;
  border: none;
  border-radius: 4px;
  color: #fff;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

button:hover {
  background-color: #d5811a;
}

/* Adiciona um pequeno efeito de transição nos campos de entrada */
input[type="text"]:hover {
  border-color: #fca130;
}

  </style>