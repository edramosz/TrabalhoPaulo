using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string ConnectionString;
        private readonly IJogoRepository _repositoryJogo;
        private readonly IUsuarioRepository _repositoryUsuario;
        private readonly ApplicationDbContext _context;
        public CarrinhoRepository(ApplicationDbContext context, IJogoRepository JogoRepos, IUsuarioRepository UserRepos)
        {
            _context = context;
            _repositoryJogo = JogoRepos;
            _repositoryUsuario = UserRepos;
        }
        public void Adicionar(Carrinho carrinho)
        {
            _context.Carrinhos.Add(carrinho);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Carrinho carrinho = _context.Carrinhos.Find(id);
            _context.Carrinhos.Remove(carrinho);
            _context.SaveChanges();
        }
        public void Editar(Carrinho carrinho)
        {
            _context.Carrinhos.Update(carrinho);
            _context.SaveChanges();
        }
        public List<Carrinho> Listar()
        {
            return _context.Carrinhos.ToList();
        }

        //private List<ReadCarrinhoDTO> TransformarListaCarrinhoEmCarrinhoDTO(List<Carrinho> list)
        //{
        //    List<ReadCarrinhoDTO> listDTO = new List<ReadCarrinhoDTO>();

        //    foreach (Carrinho car in list)
        //    {
        //        ReadCarrinhoDTO readCarrinho = new ReadCarrinhoDTO();
        //        readCarrinho.Jogo = _repositoryJogo.BuscarJogoPorId(car.JogoId);
        //        readCarrinho.Usuario = _repositoryUsuario.BuscarUsuarioPorId(car.UsuarioId);
        //        listDTO.Add(readCarrinho);
        //    }
        //    return listDTO;
        //}

        //public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
        //{
        //    __context.Carrinhos.Find();
        //}
        public Carrinho BuscarPorId(int id)
        {
            return _context.Carrinhos.Find(id);
        }

        //public List<Carrinho> CalcularCarrinho(int UsuarioId)
        //{
            
        //}
    }
}
