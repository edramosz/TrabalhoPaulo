using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface ITransacaoRepository
{
    public void Adicionar(Transacao t);
    public void Remover(int id);
    public void Editar(Transacao t);
    public List<Transacao> Listar();
    public Transacao BuscarTransacaoPorId(int id);
}
