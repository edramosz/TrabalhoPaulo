using AutoMapper;
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
    public class CarrinhoRepository
    {
        public readonly string ConnectionString;
        public CarrinhoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void AdicionarItemCarrinho(Jogo j)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Jogo>(j);
        }
        public Carrinho BuscarCarrinhoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carrinho>(id);
        }
    }
}
