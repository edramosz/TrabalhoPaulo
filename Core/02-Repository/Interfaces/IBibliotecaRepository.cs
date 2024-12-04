using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface IBibliotecaRepository
    {
        void Adicionar(Biblioteca biblioteca);
        List<Biblioteca> Listar();
        Biblioteca BuscarBibliotecaPorId(int id);
    }
}
