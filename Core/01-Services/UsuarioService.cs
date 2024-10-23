using Core._02_Repository;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class UsuarioService
    {
        public UsuarioRepository repository { get; set; }
        public UsuarioService(string _config)
        {
            repository = new UsuarioRepository(_config);
        }
        public void Adicionar(Usuario Usuario)
        {
            repository.Adicionar(Usuario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Usuario> Listar()
        {
            return repository.Listar();
        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            return repository.BuscarUsuarioPorId(id);
        }
        public void Editar(Usuario editUsuario)
        {
            repository.Editar(editUsuario);
        }
    }
}
}
