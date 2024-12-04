using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using System.Data.SQLite;


namespace Core._02_Repository
{
    public class BibliotecaRepository : IBibliotecaRepository
    {
        private readonly ApplicationDbContext _context;
        public BibliotecaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Biblioteca biblioteca)
        {
            _context.Bibliotecas.Add(biblioteca);
            _context.SaveChanges();
        }
        //public void Remover(int id)
        //{
        //    using var connection = new SQLiteConnection(ConnectionString);
        //    Biblioteca novoProduto = BuscarBibliotecaPorId(id);
        //    connection.Delete<Biblioteca>(novoProduto);
        //}
        
        public List<Biblioteca> Listar()
        {
            return _context.Bibliotecas.ToList();
        }
        public Biblioteca BuscarBibliotecaPorId(int id)
        {
            return _context.Bibliotecas.Find(id);
        }
    }
}
