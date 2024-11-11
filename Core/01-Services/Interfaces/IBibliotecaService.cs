using Core._03_Entidades;

namespace Core._01_Services.Interfaces;

public interface IBibliotecaService
{
    public void Adicionar(Biblioteca Biblioteca);
    public List<Biblioteca> Listar();
    public Biblioteca BuscarBibliotecaPorId(int id);
}
