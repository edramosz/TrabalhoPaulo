using Core._03_Entidades;

namespace Core._01_Services.Interfaces;

public interface ITransacaoService
{
    public void Adicionar(Transacao Transacao);
    public void Remover(int id);
    public List<Transacao> Listar();
    public Transacao BuscarTransacaoPorId(int id);
    public void Editar(Transacao editTransacao);
}
