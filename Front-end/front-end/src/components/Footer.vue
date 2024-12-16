<template>
    <footer class="footer">
      <div class="footer-container">
        <!-- Logo e descrição -->
        <div class="footer-logo">
          <img src="" alt="Logo do Site de Jogos" class="footer-logo-img" />
          <p class="footer-description">Sua melhor fonte para os últimos jogos e novidades do mundo dos games!</p>
        </div>
  
        <!-- Links rápidos -->
        <div class="footer-links">
          <h4>Links Rápidos</h4>
          <ul>
            <li><a href="/" class="footer-link">Página Inicial</a></li>
            <li><a href="/jogos" class="footer-link">Jogos</a></li>
            <li><a href="/noticias" class="footer-link">Notícias</a></li>
            <li><a href="/contato" class="footer-link">Contato</a></li>
          </ul>
        </div>
  
        <!-- Redes sociais -->
        <div class="footer-social">
          <h4>Conecte-se Conosco</h4>
          <div class="social-icons">
            <a href="https://facebook.com" class="social-icon" target="_blank" aria-label="Facebook">
              
            </a>
            <a href="https://twitter.com" class="social-icon" target="_blank" aria-label="Twitter">
              
            </a>
            <a href="https://instagram.com" class="social-icon" target="_blank" aria-label="Instagram">
              
            </a>
          </div>
        </div>
      </div>
  
      <!-- Direitos autorais -->
      <div class="footer-bottom">
        <p>&copy; 2024 SeuSiteDeJogos. Todos os direitos reservados.</p>
      </div>
    </footer>
  </template>
  
  <script>
  export default {
    name: 'Footer',
  }
  </script>
  
  <style scoped>
  .footer {
    background-color: #333;
    color: #ecf0f1;
    padding: 40px 0;
    font-size: 14px;
    margin-top: 223px;
  }
  
  .footer-container {
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 20px;
  }
  
  .footer-logo {
    flex: 1;
    min-width: 200px;
    text-align: center;
  }
  
  .footer-logo-img {
    width: 150px;
  }
  
  .footer-description {
    margin-top: 10px;
  }
  
  .footer-links {
    flex: 1;
    min-width: 200px;
  }
  
  .footer-links h4 {
    font-size: 16px;
    margin-bottom: 10px;
  }
  
  .footer-links ul {
    list-style: none;
    padding: 0;
  }
  
  .footer-link {
    color: #ecf0f1;
    text-decoration: none;
    display: block;
    margin-bottom: 8px;
  }
  
  .footer-link:hover {
    text-decoration: underline;
  }
  
  .footer-social {
    flex: 1;
    min-width: 200px;
    text-align: center;
  }
  
  .social-icons {
    display: flex;
    justify-content: space-around;
  }
  
  .social-icon img {
    width: 24px;
    height: 24px;
    margin: 0 8px;
  }
  
  .footer-bottom {
    text-align: center;
    margin-top: 20px;
    font-size: 12px;
  }
  
  .footer-bottom p {
    margin: 0;
  }
  </style>
  