<template>
  <form @submit="PostItem">
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
</template>

<script>
export default {
  name: "Post",
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
    async PostItem(event) {
      event.preventDefault(); // Previne o comportamento de envio do formulário
      // Agora você pode fazer a requisição POST
      const data = {
        tipo: this.tipo,
        nome: this.nome,
        preco: this.preco,
        descricao: this.descricao,
        genero: this.genero,
        estoque: this.estoque,
      };
      const dataJson = JSON.stringify(data);

      const response = await fetch(
        "https://localhost:7091/Jogo/Adicionar-Jogo",
        {
          method: "POST",
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
