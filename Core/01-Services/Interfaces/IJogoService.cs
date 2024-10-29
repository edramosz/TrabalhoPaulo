using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services.Interfaces
{
    public interface IJogoService
    {
        public void Adicionar(Jogo Jogo);
        public void Remover(int id);
        public List<Jogo> Listar();
        public Jogo BuscarJogoPorId(int id);
        public void Editar(Jogo editJogo);
    }
}
