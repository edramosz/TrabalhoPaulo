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
    public class VendaService : IVendaService
    {
        public IVendaRepository repository { get; set; }
        public VendaService(IVendaRepository repos)
        {
            repository = repos;
        }
        public void Adicionar(Venda Venda)
        {
            repository.Adicionar(Venda);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Venda> Listar()
        {
            return repository.Listar();
        }
        public Venda BuscarVendaPorId(int id)
        {
            return repository.BuscarVendaPorId(id);
        }
        public void Editar(Venda editVenda)
        {
            repository.Editar(editVenda);
        }
    }
}

