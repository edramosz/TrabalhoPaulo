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
    public class TransacaoRepository : ITransacaoRepository
    {
        public readonly string ConnectionString;

        public TransacaoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Adicionar(Transacao t)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Transacao>(t);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Transacao novoProduto = BuscarTransacaoPorId(id);
            connection.Delete<Transacao>(novoProduto);
        }
        public void Editar(Transacao t)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Transacao>(t);
        }
        public List<Transacao> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Transacao>().ToList();
        }
        public Transacao BuscarTransacaoPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Transacao>(id);
        }
    }
}
