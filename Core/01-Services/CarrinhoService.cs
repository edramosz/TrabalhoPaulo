using Core._01_Services.Interfaces;
using Core._02_Repository;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Core._03_Entidades.DTOs.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class CarrinhoService : ICarrinhoService
    {
        public ICarrinhoRepository repository { get; set; }
        public IJogoRepository Jogo_repository { get; set; }
        public CarrinhoService(string _config)
        {
            repository = new CarrinhoRepository(_config);
            Jogo_repository = new JogoRepository(_config);
        }
        public void Adicionar(Carrinho carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Carrinho> Listar()
        {
            return repository.Listar();
        }

        public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
        {
            return repository.ListarCarrinhoDoUsuario(usuarioId);
        }
        public Carrinho BuscarCarrinhoPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Carrinho editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public double CalcularCarrinho(int usuarioId)
        {
            double ValorTotal = 0;
            List<Carrinho> carrinho = repository.CalcularCarrinho(usuarioId);
            foreach (Carrinho c in carrinho)
            {
                Jogo j = Jogo_repository.BuscarJogoPorId(c.JogoId);
                ValorTotal = ValorTotal + j.Preco;
            }
            return ValorTotal;
        }
    }
}
