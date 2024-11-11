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
    public class BibliotecaRepository : IBibliotecaRepository
    {
        public readonly string ConnectionString;

        public BibliotecaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection"); ;
        }

        public void Adicionar(Biblioteca biblioteca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Biblioteca>(biblioteca);
        }
        //public void Remover(int id)
        //{
        //    using var connection = new SQLiteConnection(ConnectionString);
        //    Biblioteca novoProduto = BuscarBibliotecaPorId(id);
        //    connection.Delete<Biblioteca>(novoProduto);
        //}
        
        public List<Biblioteca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Biblioteca>().ToList();
        }
        public Biblioteca BuscarBibliotecaPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Biblioteca>(id);
        }
    }
}
