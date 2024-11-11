using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface IBibliotecaRepository
{
    public void Adicionar(Biblioteca biblioteca);
    public List<Biblioteca> Listar();
    public Biblioteca BuscarBibliotecaPorId(int id);
}
