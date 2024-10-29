using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly string ConnectionString;

        public UsuarioRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Usuario u)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Usuario>(u);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Usuario novoProduto = BuscarUsuarioPorId(id);
            connection.Delete<Usuario>(novoProduto);
        }
        public void Editar(Usuario u)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Usuario>(u);
        }
        public List<Usuario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Usuario>().ToList();
        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Usuario>(id);
        }
    }
}
