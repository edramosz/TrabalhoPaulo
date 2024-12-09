using Core._01_Services.Interfaces;
using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class BibliotecaService : IBibliotecaService
    {
        public IBibliotecaRepository repository { get; set; }
        public BibliotecaService(IBibliotecaRepository repos)
        {
            repository = repos;
        }
        public void Adicionar(Biblioteca Biblioteca)
        {
            repository.Adicionar(Biblioteca);
        }

        //public void Remover(int id)
        //{
        //    repository.Remover(id);
        //}

        public List<Biblioteca> Listar()
        {
            return repository.Listar();
        }
        public Biblioteca BuscarBibliotecaPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
    }
}

