using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface IJogoRepository
{
    public void Adicionar(Jogo j);
    public void Remover(int id);
    public void Editar(Jogo j);
    public List<Jogo> Listar();
    public Jogo BuscarJogoPorId(int id);
}
