using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace Core._02_Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;
        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario u)
        {
            _context.Usuarios.Add(u);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Usuario Usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(Usuario);
            _context.SaveChanges();
        }
        public void Editar(Usuario u)
        {
            _context.Usuarios.Update(u);
            _context.SaveChanges();
        }
        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
