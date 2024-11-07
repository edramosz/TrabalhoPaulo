using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Core._01_Services;
using Core._01_Services.Interfaces;
using Core._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        private IJogoService _service;
        //private readonly IMapper _mapper;

        public JogoController(IJogoService serv)//,IMapper mapper,)
        {
            _service = serv;
            //_mapper = mapper;
        }

        
        /// <summary>
        /// Endpoint parra cadastrar um jogo
        /// </summary>
        /// <param name="j"></param>

        [HttpPost("Adicionar-Jogo")]

        public void AdicionarJogo(Jogo j)
        {
            _service.Adicionar(j);
        }
        [HttpGet("Listar-Jogo")]

        public List<Jogo> ListarJogo()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Jogo")]

        public void DeletarJogo(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Jogo")]

        public void EditarJogo(Jogo Jogo)
        {
            _service.Editar(Jogo);
        }

        [HttpGet("Buscar-Jogo-por-Id")]

        public Jogo BuscarPorId(int id)
        {
            return _service.BuscarJogoPorId(id);
        }
    }
}

