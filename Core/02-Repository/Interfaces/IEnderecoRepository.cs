using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        void Adicionar(Endereco e);
        void Remover(int id);
        void Editar(Endereco e);
        List<Endereco> Listar();
        Endereco BuscarEnderecoPorId(int id);
    }
}
