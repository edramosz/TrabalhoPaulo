using Core._03_Entidades;
using Microsoft.EntityFrameworkCore;


namespace Core._02_Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
