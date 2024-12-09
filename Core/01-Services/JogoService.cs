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
    public class JogoService : IJogoService
    {
        public IJogoRepository repository { get; set; }
        public JogoService(IJogoRepository repos)
        {
            repository = repos;
        }
        public void Adicionar(Jogo Jogo)
        {
            repository.Adicionar(Jogo);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Jogo> Listar()
        {
            return repository.Listar();
        }
        public Jogo BuscarJogoPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Jogo editJogo)
        {
            repository.Editar(editJogo);
        }
    }
}
