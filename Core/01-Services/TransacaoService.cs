using Core._02_Repository;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01_Services
{
    public class TransacaoService
    {
        public TransacaoRepository repository { get; set; }
        public TransacaoService(string _config)
        {
            repository = new TransacaoRepository(_config);
        }
        public void Adicionar(Transacao Transacao)
        {
            repository.Adicionar(Transacao);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Transacao> Listar()
        {
            return repository.Listar();
        }
        public Transacao BuscarTransacaoPorId(int id)
        {
            return repository.BuscarTransacaoPorId(id);
        }
        public void Editar(Transacao editTransacao)
        {
            repository.Editar(editTransacao);
        }
    }
}
}
