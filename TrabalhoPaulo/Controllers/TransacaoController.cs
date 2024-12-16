using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        private ITransacaoService _service;
        //private readonly IMapper _mapper;

        public TransacaoController(ITransacaoService serv) //,IMapper mapper)
        {
            _service = serv;
            //_mapper = mapper;
        }

        /// <summary>
        /// Endpoint para Adicionar uma transação
        /// </summary>
        /// <param name="t"></param>
        /// 
        [HttpPost("Adicionar-Transacao")]

        public void AdicionarTransacao(Transacao t)
        {
            _service.Adicionar(t);
        }
        /// <summary>
        /// Endpoint para Listar as transações
        /// </summary>

        [HttpGet("Listar-Transacao")]

        public List<Transacao> ListarTransacao()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Endpoint para remover uma transação
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete("Remover-Transacao")]

        public void DeletarTransacao(int id)
        {
            _service.Remover(id);
        }

        /// <summary>
        /// Endpoint para Buscar uma biblioteca por id
        /// </summary>
        /// <param name="Transacao"></param>
        [HttpPut("Editar-Transacao")]

        public void EditarTransacao(Transacao Transacao)
        {
            _service.Editar(Transacao);
        }

        /// <summary>
        /// Endpoint para Buscar uma transação por id
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpGet("Buscar-Transacao-por-Id")]

        public Transacao BuscarPorId(int id)
        {
            return _service.BuscarTransacaoPorId(id);
        }
    }
}
