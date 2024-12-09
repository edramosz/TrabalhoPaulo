using Core._02_Repository.Interfaces;
using Core._03_Entidades;


namespace API.DataConfig
{
    public class BibliotecaRepository : BaseRepository<Biblioteca>, IBibliotecaRepository
    {
        public BibliotecaRepository(ApplicationDbContext context)
            : base(context) { }

    }
}
