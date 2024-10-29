using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface IEnderecoRepository
{
    public void Adicionar(Endereco e);
    public void Remover(int id);
    public void Editar(Endereco e);
    public List<Endereco> Listar();
    public Endereco BuscarEnderecoPorId(int id);
}
