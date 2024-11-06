using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Data
{
    public class InicializadorBd
    {
        private const string ConnectionString = "Data Source=LojaJogo.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Jogos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Tipo INTEGER NOT NULL,
                 Nome TEXT NOT NULL,
                 Preco REAL NOT NULL,
                 Descricao TEXT NOT NULL,
                 Genero TEXT NOT NULL,
                 Estoque INTEGER 
                );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Usuarios(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Username TEXT NOT NULL,
                 Senha TEXT NOT NULL
                );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Carrinhos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 JogoId INTEGER NOT NULL,
                 UsuarioId INTEGER NOT NULL
                 );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Enderecos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Bairro TEXT NOT NULL,
                 Rua TEXT NOT NULL,
                 Numero INTEGER NOT NULL,
                 UsuarioID INTEGER NOT NULL
                 );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Vendas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdEndereco INTEGER NOT NULL,
                 ValorTotal REAL NOT NULL
                 );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Transacoes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 CompraId INTEGER NOT NULL,
                 Data DATE NOT NULL,
                 Parcelamento INTEGER NOT NULL,
                 MetodoPagamento TEXT NOT NULL
                 );";

                commandoSQL += @"
                CREATE TABLE IF NOT EXISTS Bibliotecas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 JogoId INTEGER NOT NULL,
                 UsuarioId INTEGER NOT NULL
                 );";

                connection.Execute(commandoSQL);
            }
        }
    }
}
