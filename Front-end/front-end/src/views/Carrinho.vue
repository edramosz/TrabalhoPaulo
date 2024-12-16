<template>
  <div class="cart-container">
    <h1 class="cart-title">Carrinho de Compras</h1>

    <!-- Lista de itens no carrinho -->
    <div v-if="carrinho.length > 0" class="cart-items">
      <ul>
        <li v-for="item in carrinho" :key="item.id" class="cart-item">
          <p><strong>{{ item.nome }}</strong> - R$ {{ item.preco }} x {{ item.quantidade }}</p>
        </li>
      </ul>
      <div class="total">
        <p><strong>Total:</strong> R$ {{ total }}</p>
      </div>
    </div>

    <!-- Se não houver itens no carrinho -->
    <div v-else class="empty-cart">
      <p>Seu carrinho está vazio.</p>
    </div>

    <!-- Formulário para informações de pagamento e entrega -->
    <div v-if="carrinho.length > 0" class="checkout-form">
      <h2>Informações para a Compra</h2>
      
      <form @submit.prevent="finalizarCompra">
        <div class="form-group">
          <label for="nome">Nome Completo:</label>
          <input type="text" id="nome" v-model="usuario.nome" required />
        </div>

        <div class="form-group">
          <label for="endereco">Endereço:</label>
          <input type="text" id="endereco" v-model="usuario.endereco" required />
        </div>

        <div class="form-group">
          <label for="endereco">Bairro:</label>
          <input type="text" id="bairro" v-model="usuario.bairro" required />
        </div>

        <div class="form-group">
          <label for="endereco">Cidade:</label>
          <input type="text" id="cidade" v-model="usuario.cidade" required />
        </div>

        <div class="form-group">
          <label for="pagamento">Forma de Pagamento:</label>
          <select id="pagamento" v-model="usuario.pagamento" required>
            <option value="cartao">Cartão de Crédito</option>
            <option value="boleto">Boleto Bancário</option>
            <option value="pix">PIX</option>
          </select>
        </div>

        <button type="submit" class="btn-checkout">Finalizar Compra</button>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "Carrinho",
  data() {
    return {
      carrinho: [],
      usuario: {
        nome: "",
        endereco: "",
        bairro: "",
        cidade: "",
        pagamento: "cartao", // Forma de pagamento padrão
      },
    };
  },
  computed: {
    // Calcula o valor total do carrinho
    total() {
      return this.carrinho.reduce((acc, item) => acc + item.preco * item.quantidade, 0).toFixed(2);
    },
  },
  methods: {
    // Recupera o carrinho do localStorage quando o componente é montado
    carregarCarrinho() {
      const carrinho = JSON.parse(localStorage.getItem("carrinho")) || [];
      this.carrinho = carrinho;
    },

    // Função para finalizar a compra
    finalizarCompra() {
      // Aqui você pode processar os dados de pagamento e envio, por exemplo, enviar para um servidor
      alert(`Compra finalizada!\n\nEm alguns dias os produtos serão entregues em sua residência!`);
      
      // Remove o carrinho após a compra
      localStorage.removeItem("carrinho");
      this.carrinho = []; // Limpa os itens no carrinho
    },
  },
  mounted() {
    this.carregarCarrinho(); // Carrega o carrinho quando o componente for montado
  },
};
</script>

<style scoped>
.cart-container {
  width: 80%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 20px;
}

.cart-title {
  font-size: 2rem;
  margin-bottom: 20px;
}

.cart-items ul {
  list-style: none;
  padding: 0;
}

.cart-item {
  background-color: #f9f9f9;
  margin-bottom: 15px;
  padding: 15px;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.total {
  font-size: 1.5rem;
  margin-top: 20px;
  text-align: right;
}

.empty-cart {
  padding: 20px;
  text-align: center;
  font-size: 1.2rem;
  color: #888;
}

.checkout-form {
  margin-top: 30px;
}

.checkout-form h2 {
  font-size: 1.8rem;
  margin-bottom: 20px;
}

.form-group {
  margin-bottom: 15px;
}

label {
  font-size: 1.1rem;
  display: block;
  margin-bottom: 5px;
}

input, select {
  width: 100%;
  padding: 10px;
  font-size: 1rem;
  border-radius: 5px;
  border: 1px solid #ddd;
}

input:focus, select:focus {
  border-color: #007bff;
  outline: none;
}

button[type="submit"] {
  padding: 15px 30px;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  font-size: 1.2rem;
  cursor: pointer;
  transition: background-color 0.3s;
}

button[type="submit"]:hover {
  background-color: #0056b3;
}
</style>
