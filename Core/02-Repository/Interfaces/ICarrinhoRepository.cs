using Core._03_Entidades;
using Core._03_Entidades.DTOs.Carrinho;

namespace Core._02_Repository.Interfaces;

public interface ICarrinhoRepository
{
    public void Adicionar(Carrinho carrinho);
    public void Remover(int id);
    public void Editar(Carrinho carrinho);
    public List<Carrinho> Listar();
    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId);
    public Carrinho BuscarPorId(int id);
    public List<Carrinho> CalcularCarrinho(int UsuarioId);

}
