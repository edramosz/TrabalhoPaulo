using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context)
            : base(context) { }
    }
}
