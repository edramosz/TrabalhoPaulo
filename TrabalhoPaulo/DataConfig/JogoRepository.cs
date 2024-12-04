using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using System.Data.SQLite;

namespace Core._02_Repository
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ApplicationDbContext _context;
        public JogoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Jogo j)
        {
            _context.Jogos.Add(j);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Jogo jogo = _context.Jogos.Find(id);
            _context.Jogos.Remove(jogo);
            _context.SaveChanges();
        }
        public void Editar(Jogo j)
        {
            _context.Jogos.Update(j);
            _context.SaveChanges();
        }
        public List<Jogo> Listar()
        {
           return _context.Jogos.ToList();
        }
        public Jogo BuscarJogoPorId(int id)
        {
            return _context.Jogos.Find(id);
        }

    }
}
