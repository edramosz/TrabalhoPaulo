﻿using AutoMapper;
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

        [HttpPost("Adicionar-Transacao")]

        public void AdicionarTransacao(Transacao t)
        {
            _service.Adicionar(t);
        }
        [HttpGet("Listar-Transacao")]

        public List<Transacao> ListarTransacao()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Transacao")]

        public void DeletarTransacao(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Transacao")]

        public void EditarTransacao(Transacao Transacao)
        {
            _service.Editar(Transacao);
        }

        [HttpGet("Buscar-Transacao-por-Id")]

        public Transacao BuscarPorId(int id)
        {
            return _service.BuscarTransacaoPorId(id);
        }
    }
}
