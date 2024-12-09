using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class CarrinhoRepository : BaseRepository<Carrinho>, ICarrinhoRepository
    {
        public CarrinhoRepository(ApplicationDbContext context)
            : base(context) { }

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


        //public List<Carrinho> CalcularCarrinho(int UsuarioId)
        //{

        //}
    }
}
