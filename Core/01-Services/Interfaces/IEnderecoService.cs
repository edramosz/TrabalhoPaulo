using Core._03_Entidades;

namespace Core._01_Services.Interfaces;

public interface IEnderecoService
{
    public void Adicionar(Endereco Endereco);
    public void Remover(int id);
    public List<Endereco> Listar();
    public Endereco BuscarEnderecoPorId(int id);
    public void Editar(Endereco editEndereco);
}
