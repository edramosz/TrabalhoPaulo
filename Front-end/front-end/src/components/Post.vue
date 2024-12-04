<template>
  <form @submit="PostItem">
    <input type="text" id="Nome" placeholder="Nome" v-model="Nome" />
    <input type="text" id="Tipo" placeholder="Tipo" v-model="Tipo" />
    <input type="text" id="Preco" placeholder="Preco" v-model="Preco" />
    <input
      type="text"
      id="Descricao"
      placeholder="Descricao"
      v-model="Descricao"
    />
    <input type="text" id="Genero" placeholder="Genero" v-model="Genero" />
    <input type="text" id="Estoque" placeholder="Estoque" v-model="Estoque" />
    <button type="submit">Envie</button>
  </form>
</template>

<script>
export default {
  name: "Post",
  data() {
    return {
      Nome: "",
      Tipo: "",
      Preco: "",
      Descricao: "",
      Genero: "",
      Estoque: "",
      json: [],
    };
  },
  methods: {
    async PostItem() {
      const data = {
        nome: this.Nome,
        tipo: this.Tipo,
        preco: this.Preco,
        descricao: this.Descricao,
        genero: this.Genero,
        estoque: this.Estoque,
      };
      this.json = JSON.stringify(data);
      const response = await fetch(
        "https://localhost:7091/Jogo/Adicionar-Jogo",
        {
          method: "Post",
          headers: {
            Accept: "application/json",
          },
          body: DataJson,
        }
      );
    },
  },
};
</script>
