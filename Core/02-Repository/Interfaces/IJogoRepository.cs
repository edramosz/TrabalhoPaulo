using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface IJogoRepository
    {
        void Adicionar(Jogo j);
        void Remover(int id);
        void Editar(Jogo j);
        List<Jogo> Listar();
        Jogo BuscarJogoPorId(int id);
    }
}
