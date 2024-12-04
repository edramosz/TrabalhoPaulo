using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface IVendaRepository
    {
        void Adicionar(Venda v);
        void Remover(int id);
        void Editar(Venda v);
        List<Venda> Listar();
        Venda BuscarVendaPorId(int id);
    }
}
