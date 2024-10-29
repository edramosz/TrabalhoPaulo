using Core._03_Entidades;

namespace Core._02_Repository.Interfaces;

public interface IUsuarioRepository
{
    public void Adicionar(Usuario u);
    public void Remover(int id);
    public void Editar(Usuario u);
    public List<Usuario> Listar();
    public Usuario BuscarUsuarioPorId(int id);
}
