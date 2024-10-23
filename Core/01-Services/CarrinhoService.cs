using Core._02_Repository;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class CarrinhoService
    {
        public CarrinhoRepository repository { get; set; }
        public CarrinhoService(string _config)
        {
            repository = new CarrinhoRepository(_config);
        }
        public void AdicionarItemCarrinho(Carrinho carrinho)
        {
            repository.AdicionarItemCarrinho(carrinho);
        }

        public void Remover(int id)
        {
            repository.RemoverCarrinho(id);
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
            return repository.BuscarCarrinhoPorId(id);
        }
        public void Editar(Carrinho editPessoa)
        {
            repository.EditarCarrinho(editPessoa);
        }
    }
}
