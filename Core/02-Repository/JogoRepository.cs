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
    public class JogoRepository : IJogoRepository
    {
        public readonly string ConnectionString;

        public JogoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Jogo j)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Jogo>(j);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Jogo novoProduto = BuscarJogoPorId(id);
            connection.Delete<Jogo>(novoProduto);
        }
        public void Editar(Jogo j)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Jogo>(j);
        }
        public List<Jogo> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Jogo>().ToList();
        }
        public Jogo BuscarJogoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Jogo>(id);
        }
    }
}
