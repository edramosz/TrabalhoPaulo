using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface IVendaRepository
{
    public void Adicionar(Venda v);
    public void Remover(int id);
    public void Editar(Venda v);
    public List<Venda> Listar();
    public Venda BuscarVendaPorId(int id);
}
