using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository
{
    public class VendaRepository : IVendaRepository
    {
        public readonly string ConnectionString;

        public VendaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Venda v)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Venda>(v);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Venda novoProduto = BuscarVendaPorId(id);
            connection.Delete<Venda>(novoProduto);
        }
        public void Editar(Venda v)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Venda>(v);
        }
        public List<Venda> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Venda>().ToList();
        }
        public Venda BuscarVendaPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Venda>(id);
        }
    }
}
