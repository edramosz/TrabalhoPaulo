<template>
    <div>
      <h1>Loja de Jogos</h1>
  
      <!-- Formulário de Adicionar Novo Jogo -->
      <div>
        <h2>Criar Novo Jogo</h2>
        <form @submit.prevent="createGame">
          <input v-model="newGame.name" placeholder="Nome do Jogo" />
          <input v-model="newGame.price" type="number" placeholder="Preço" />
          <button type="submit">Adicionar Jogo</button>
        </form>
      </div>
  
      <!-- Lista de Jogos -->
      <h2>Jogos Disponíveis</h2>
      <ul v-if="games.length">
        <li v-for="game in games" :key="game.id">
          <strong>{{ game.name }}</strong> - R$ {{ game.price }}
          <button @click="deleteGame(game.id)">Excluir</button>
          <button @click="editGame(game)">Editar</button>
        </li>
      </ul>
  
      <!-- Formulário de Editar Jogo -->
      <div v-if="editingGame">
        <h2>Editar Jogo</h2>
        <form @submit.prevent="updateGame">
          <input v-model="editingGame.name" placeholder="Nome do Jogo" />
          <input v-model="editingGame.price" type="number" placeholder="Preço" />
          <button type="submit">Atualizar Jogo</button>
        </form>
      </div>
    </div>
  </template>
  
  <script>
  import Swagger from 'swagger-client';
  
  export default {
    data() {
      return {
        games: [],
        newGame: { name: '', price: '' },
        editingGame: null
      };
    },
    mounted() {
      this.fetchGames();
    },
    methods: {
      async fetchGames() {
        try {
          // Substitua pela URL do seu arquivo Swagger ou a URL da sua API
          const client = await Swagger('https://localhost:7091/Jogo/Adicionar-Jogo');
          
          // Chamada para obter a lista de jogos
          const response = await client.apis.Game.getGames();
          this.games = response.body;
        } catch (error) {
          console.error('Erro ao carregar jogos:', error);
        }
      },
  
      async createGame() {
        try {
          // Criação de um novo jogo
          const client = await Swagger('https://localhost:7091/swagger/index.html');
          const response = await client.apis.Game.createGame({ body: this.newGame });
          
          // Atualizar a lista de jogos após criar
          this.games.push(response.body);
          this.newGame = { name: '', price: '' }; // Limpar o formulário
        } catch (error) {
          console.error('Erro ao criar jogo:', error);
        }
      },
  
      async updateGame() {
        try {
          // Atualizar o jogo
          const client = await Swagger('https://localhost:7091/swagger/index.html');
          const response = await client.apis.Game.updateGame({ gameId: this.editingGame.id, body: this.editingGame });
          
          // Atualizar o item na lista de jogos
          const index = this.games.findIndex(game => game.id === this.editingGame.id);
          if (index !== -1) {
            this.games.splice(index, 1, response.body); // Substitui o jogo atualizado
          }
          this.editingGame = null; // Limpar formulário de edição
        } catch (error) {
          console.error('Erro ao atualizar jogo:', error);
        }
      },
  
      async deleteGame(gameId) {
        try {
          // Deletar o jogo
          const client = await Swagger('https://localhost:7091/swagger/index.html');
          await client.apis.Game.deleteGame({ gameId });
          
          // Remover o jogo da lista
          this.games = this.games.filter(game => game.id !== gameId);
        } catch (error) {
          console.error('Erro ao deletar jogo:', error);
        }
      },
  
      editGame(game) {
        // Preenche o formulário de edição com os dados do jogo
        this.editingGame = { ...game };
      }
    }
  };
  </script>
  
  <style scoped>
  /* Adicione estilos específicos aqui */
  </style>
  