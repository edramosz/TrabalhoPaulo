<template>
    <div class="page-container">
      <div class="content">
        <h1 class="page-title">Lista de Jogos</h1>
        <div class="button-container">
          <button @click="ListarJogos" class="btn-load">Carregar Produto</button>
        </div>
        <ul class="product-list">
          <li v-for="jogo in Jogos" :key="jogo.id" class="product-item">
            Id: {{ jogo.id }} - Nome: {{ jogo.nome }} - Preço: {{ jogo.preco }} -
            Tipo: {{ jogo.tipo }} - Descricao: {{ jogo.descricao }}- Genero:
            {{ jogo.genero }} - Estoque: {{ jogo.estoque }}
          </li>
        </ul>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: "Get",
    data() {
      return {
        Jogos: [],
      };
    },
    methods: {
      async ListarJogos() {
        const apiUrl = "https://localhost:7091/Jogo/Listar-Jogo";
        const response = await fetch(apiUrl, {
          method: "GET",
          headers: {
            Accept: "application/json",
          },
        });
        this.Jogos = await response.json();
      },
    },
  };
  </script>
  