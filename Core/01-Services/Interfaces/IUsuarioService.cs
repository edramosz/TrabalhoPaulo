using Core._03_Entidades;
using Core._03_Entidades.DTOs;

namespace Core._01_Services.Interfaces;

public interface IUsuarioService
{
    void Adicionar(Usuario Usuario);
    void Remover(int id);
    List<Usuario> Listar();
    Usuario BuscarUsuarioPorId(int id);
    void Editar(Usuario editUsuario);
    Usuario FazerLogin(UsuarioLoginDTO usuarioLogin);
}
