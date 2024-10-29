using Core._03_Entidades;

namespace Core._01_Services.Interfaces;

public interface IVendaService
{
    public void Adicionar(Venda Venda);
    public void Remover(int id);

    public List<Venda> Listar();

    public Venda BuscarVendaPorId(int id);
    public void Editar(Venda editVenda);
}
