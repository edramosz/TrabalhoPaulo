using Core._01_Services.Interfaces;
using Core._02_Repository;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class EnderecoService : IEnderecoService
    {
        public IEnderecoRepository repository { get; set; }
        public EnderecoService(IEnderecoRepository repos)
        {
            repository = repos;
        }
        public void Adicionar(Endereco Endereco)
        {
            repository.Adicionar(Endereco);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Endereco> Listar()
        {
            return repository.Listar();
        }
        public Endereco BuscarEnderecoPorId(int id)
        {
            return repository.BuscarEnderecoPorId(id);
        }
        public void Editar(Endereco editEndereco)
        {
            repository.Editar(editEndereco);
        }
    }
}

