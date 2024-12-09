using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDbContext context)
            : base(context) { }
    }
}
