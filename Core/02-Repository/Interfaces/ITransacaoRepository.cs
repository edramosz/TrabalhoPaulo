﻿using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces
{
    public interface ITransacaoRepository
    {
        void Adicionar(Transacao t);
        void Remover(int id);
        void Editar(Transacao t);
        List<Transacao> Listar();
        Transacao BuscarTransacaoPorId(int id);
    }
}
