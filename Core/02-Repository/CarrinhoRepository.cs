using AutoMapper;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Core._03_Entidades.DTOs.Carrinho;
using Dapper;
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
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string ConnectionString;
        private readonly IJogoRepository _repositoryJogo;
        private readonly IUsuarioRepository _repositoryUsuario;
        public CarrinhoRepository(IConfiguration config, IJogoRepository JogoRepos, IUsuarioRepository UserRepos)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
            _repositoryJogo = JogoRepos;
            _repositoryUsuario = UserRepos;
        }
        public void Adicionar(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carrinho>(carrinho);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carrinho carrinho = BuscarPorId(id);
            connection.Delete<Carrinho>(carrinho);
        }
        public void Editar(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(carrinho);
        }
        public List<Carrinho> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> list = connection.GetAll<Carrinho>().ToList();
            //TransformarListaCarrinhoEmCarrinhoDTO();
            return list;
        }

        private List<ReadCarrinhoDTO> TransformarListaCarrinhoEmCarrinhoDTO(List<Carrinho> list)
        {
            List<ReadCarrinhoDTO> listDTO = new List<ReadCarrinhoDTO>();

            foreach (Carrinho car in list)
            {
                ReadCarrinhoDTO readCarrinho = new ReadCarrinhoDTO();
                readCarrinho.Jogo = _repositoryJogo.BuscarJogoPorId(car.JogoId);
                readCarrinho.Usuario = _repositoryUsuario.BuscarUsuarioPorId(car.UsuarioId);
                listDTO.Add(readCarrinho);
            }
            return listDTO;
        }

        public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> list = connection.Query<Carrinho>($"SELECT Id, UsuarioId, ProdutoId FROM Carrinhos WHERE UsuarioId = {usuarioId}").ToList();
            List<ReadCarrinhoDTO> listDTO = TransformarListaCarrinhoEmCarrinhoDTO(list);
            return listDTO;
        }
        public Carrinho BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carrinho>(id);
        }

        public List<Carrinho> CalcularCarrinho(int UsuarioId)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> list = connection.Query<Carrinho>($"SELECT ProdutoId FROM Carrinhos WHERE UsuarioId = {UsuarioId}").ToList();
            return list;
        }
    }
}
