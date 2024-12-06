using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace Core._02_Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ApplicationDbContext _context;
        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Venda v)
        {
            _context.Vendas.Add(v);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Venda Venda = _context.Vendas.Find(id);
            _context.Vendas.Remove(Venda);
            _context.SaveChanges();
        }
        public void Editar(Venda v)
        {
            _context.Vendas.Update(v);
            _context.SaveChanges();
        }
        public List<Venda> Listar()
        {
            return _context.Vendas.ToList();
        }
        public Venda BuscarVendaPorId(int id)
        {
            return _context.Vendas.Find(id);
        }
    }
}
