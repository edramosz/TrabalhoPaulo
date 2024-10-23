using Core._02_Repository;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class VendaService
    {
        public VendaRepository repository { get; set; }
        public VendaService(string _config)
        {
            repository = new VendaRepository(_config);
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
}
