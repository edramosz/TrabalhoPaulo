using Core._03_Entidades;
using Core._03_Entidades.DTOs.Carrinho;

namespace Core._01_Services.Interfaces;

public interface ICarrinhoService
{
    public void Adicionar(Carrinho carrinho);
    public void Remover(int id);
    public List<Carrinho> Listar();
    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId);
    public Carrinho BuscarCarrinhoPorId(int id);
    public void Editar(Carrinho editPessoa);
    public double CalcularCarrinho(int usuarioId);
}
