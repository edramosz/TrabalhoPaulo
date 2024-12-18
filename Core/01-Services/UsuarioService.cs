﻿using Core._01_Services.Interfaces;
using Core._02_Repository;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Core._03_Entidades.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class UsuarioService : IUsuarioService
    {
        public IUsuarioRepository repository { get; set; }
        public UsuarioService(IUsuarioRepository repos)
        {
            repository = repos;
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
            return repository.BuscarPorId(id);
        }
        public void Editar(Usuario editUsuario)
        {
            repository.Editar(editUsuario);
        }
        public Usuario FazerLogin(UsuarioLoginDTO usuarioLogin)
        {
            List<Usuario> listUsuario = Listar();
            foreach (Usuario usuario in listUsuario)
            {
                if (usuario.Username == usuarioLogin.Username
                    && usuario.Senha == usuarioLogin.Senha)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}

