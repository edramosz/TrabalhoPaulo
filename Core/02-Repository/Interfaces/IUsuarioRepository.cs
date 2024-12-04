using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario u);
        void Remover(int id);
        void Editar(Usuario u);
        List<Usuario> Listar();
        Usuario BuscarUsuarioPorId(int id);
    }
}
