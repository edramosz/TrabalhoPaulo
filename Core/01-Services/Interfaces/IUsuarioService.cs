using Core._03_Entidades;

namespace Core._01_Services.Interfaces;

public interface IUsuarioService
{
    public void Adicionar(Usuario Usuario);
    public void Remover(int id);
    public List<Usuario> Listar();
    public Usuario BuscarUsuarioPorId(int id);
    public void Editar(Usuario editUsuario);
}
