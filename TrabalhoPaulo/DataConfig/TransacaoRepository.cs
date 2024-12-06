using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly ApplicationDbContext _context;
        public TransacaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Transacao t)
        {
            _context.Transacoes.Add(t);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Transacao t = _context.Transacoes.Find(id);
            _context.Transacoes.Remove(t);
            _context.SaveChanges();
        }
        public void Editar(Transacao t)
        {
            _context.Transacoes.Update(t);
            _context.SaveChanges();
        }
        public List<Transacao> Listar()
        {
            return _context.Transacoes.ToList();
        }
        public Transacao BuscarTransacaoPorId(int id)
        {
            return _context.Transacoes.Find(id);
        }
    }
}
