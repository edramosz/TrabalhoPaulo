<template>
  <div id="navbar">
    <ul>
      <RouterLink to="/get" class="nav-item"><li>GET</li></RouterLink>
      <RouterLink to="/post" class="nav-item"><li>POST</li></RouterLink>
      <RouterLink to="/delete" class="nav-item"><li>DELETE</li></RouterLink>
      <RouterLink to="/put" class="nav-item"><li>PUT</li></RouterLink>
      <RouterLink to="/carrinho" class="nav-item"><li>Carrinho</li></RouterLink>
    </ul>
  </div>
</template>

<script>
export default {
  name: 'Navbar',
}
</script>

<style scoped>
#navbar {
  background-color: #333; /* Cor de fundo mais sofisticada */
  height: 70px;
  display: flex;
  justify-content: center; /* Centraliza os itens */
  align-items: center;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1); /* Sombra suave para destacar a navbar */
}

ul {
  display: flex;
  list-style: none;
  padding: 0;
  margin: 0;
}

.nav-item {
  text-decoration: none; /* Remove o sublinhado dos links */
}

li {
  color: #fff; /* Cor padrão do texto */
  margin: 0 20px; /* Espaçamento entre os itens */
  font-size: 18px;
  font-family: 'Arial', sans-serif;
  cursor: pointer; /* Cursor de ponteiro para links */
  padding: 10px 0;
  transition: color 0.3s ease, transform 0.3s ease; /* Transições suaves */
}

li:hover {
  transform: scale(1.1); /* Efeito de aumento ao passar o mouse */
}

/* Hover effects para cada link */
#navbar .nav-item:nth-child(1):hover li {
  color: #61affe; /* Cor azul para GET */
}

#navbar .nav-item:nth-child(2):hover li {
  color: #49cc90; /* Cor verde para POST */
}

#navbar .nav-item:nth-child(3):hover li {
  color: #f93e3e; /* Cor vermelha para DELETE */
}

#navbar .nav-item:nth-child(4):hover li {
  color: #fca130; /* Cor laranja para PUT */
}

#navbar .nav-item:nth-child(5):hover li {
  color: #ff69b4; /* Cor rosa para Carrinho */
}

/* Estilos para dispositivos móveis */
@media (max-width: 768px) {
  ul {
    flex-direction: column; /* Empilha os itens verticalmente */
    align-items: center; /* Centraliza os itens */
  }

  li {
    margin: 10px 0; /* Ajusta a margem para dispositivos móveis */
    font-size: 16px; /* Reduz o tamanho da fonte */
  }
}
</style>
