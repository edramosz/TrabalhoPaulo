<template>
    <div>
      <!-- Botão para deletar um item -->
      <button @click="deleteItem(1)">Excluir Jogo</button> <!-- Exemplo com ID fictício -->
    </div>
  </template>
  
  <script>
  export default {
    name: "Delete",
    methods: {
      // Método DELETE
      async deleteItem(id = 1) {
        const confirmDelete = window.confirm("Tem certeza que deseja excluir este item?");
        if (!confirmDelete) return;
  
        try {
          // Fazendo a requisição DELETE para o endpoint da API
          const response = await fetch(`https://localhost:7091/Jogo/Remover-Jogo/${id}`, {
            method: 'DELETE',
            headers: {
              "Content-Type": "application/json",
            },
          });
  
          // Verificando se a requisição foi bem-sucedida
          if (response.ok) {
            console.log('Jogo excluído com sucesso!');
            // Adicione aqui qualquer lógica adicional, como atualizar a lista de jogos, etc.
          } else {
            console.error('Erro ao excluir jogo', response.status);
          }
        } catch (error) {
          console.error('Erro ao tentar excluir o jogo:', error);
        }
      },
    },
  };
  </script>
  