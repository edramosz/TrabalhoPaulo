<template>
  <div class="page-container">
    <div class="content">
      <h1 class="page-title">Lista de Jogos</h1>
      <div class="button-container">
        <button @click="ListarJogos" class="btn-load">Carregar Produtos</button>
      </div>
      <div class="product-grid">
        <div v-for="jogo in Jogos" :key="jogo.id" class="product-card">
          <img :src="jogo.image" :alt="jogo.nome" class="product-image" />
          <div class="product-details">
            <h3 class="product-title">{{ jogo.nome }}</h3>
            <p class="product-description">{{ jogo.descricao }}</p>
            <div class="product-footer">
              <span class="product-price">R$ {{ jogo.preco }}</span>
              <button @click="adicionarAoCarrinho(jogo)" class="btn-add-to-cart">Adicionar ao Carrinho</button>
            </div>
          </div>
        </div>
      </div>
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
    adicionarAoCarrinho(jogo) {
      let carrinho = JSON.parse(localStorage.getItem("carrinho")) || [];
      const itemExistente = carrinho.find((item) => item.id === jogo.id);
      if (itemExistente) {
        itemExistente.quantidade += 1;
      } else {
        jogo.quantidade = 1;
        carrinho.push(jogo);
      }
      localStorage.setItem("carrinho", JSON.stringify(carrinho));
      alert(`${jogo.nome} foi adicionado ao carrinho.`);
    },
  },
};
</script>

<style scoped>
/* Estilo global para o corpo */
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

/* Contêiner da página */
.page-container {
  width: 90%;
  max-width: 1200px;
  background-color: #fff;
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

/* Título da página */
.page-title {
  font-size: 2rem;
  text-align: center;
  margin-bottom: 20px;
  color: #333;
}

/* Botão de carregar os produtos */
.button-container {
  display: flex;
  justify-content: center;
  margin-bottom: 20px;
}

.btn-load {
  padding: 12px 24px;
  background-color: #61affe;
  color: white;
  border: none;
  border-radius: 5px;
  font-size: 1.1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.btn-load:hover {
  background-color: #357ab7;
}

/* Layout da grid para exibir os jogos */
.product-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
  gap: 20px;
}

/* Estilo do card de cada produto */
.product-card {
  background-color: #f9f9f9;
  padding: 15px;
  border-radius: 8px;
  box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
  transition: transform 0.3s ease;
}

.product-card:hover {
  transform: translateY(-5px);
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
}

/* Estilo da imagem do produto */
.product-image {
  width: 100%;
  height: auto;
  border-radius: 5px;
  margin-bottom: 15px;
}

/* Detalhes do jogo no card */
.product-details {
  text-align: center;
}

.product-title {
  font-size: 1.4rem;
  font-weight: bold;
  margin-bottom: 10px;
  color: #333;
}

.product-description {
  font-size: 1rem;
  color: #666;
  margin-bottom: 15px;
}

/* Estilo para o rodapé do card */
.product-footer {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

/* Estilo do preço e tipo de jogo */
.product-price {
  font-size: 1.2rem;
  color: #61affe;
}

.product-type {
  font-size: 1rem;
  color: #333;
}

/* Botão de adicionar ao carrinho */
.btn-add-to-cart {
  padding: 8px 16px;
  background-color: #61affe;
  color: white;
  border: none;
  border-radius: 5px;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.btn-add-to-cart:hover {
  background-color: #357ab7;
}
</style>
