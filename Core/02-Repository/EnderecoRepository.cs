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
    public class EnderecoRepository
    {
        public readonly string ConnectionString;

        public EnderecoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Endereco e)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Endereco>(e);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Endereco novoProduto = BuscarEnderecoPorId(id);
            connection.Delete<Endereco>(novoProduto);
        }
        public void Editar(Endereco e)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Endereco>(e);
        }
        public List<Endereco> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Endereco>().ToList();
        }
        public Endereco BuscarEnderecoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Endereco>(id);
        }
    }
}
