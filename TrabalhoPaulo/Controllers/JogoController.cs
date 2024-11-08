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
        /// Endpoint para Cadastrar um Jogo
        /// </summary>
        /// <param name="jogo"></param>

        [HttpPost("Adicionar-Jogo")]

        public IActionResult AdicionarJogo(Jogo jogo)
        {
            try
            {
                _service.Adicionar(jogo);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao adicionar um Jogo, " +
                    $"o erro foi \n {erro.Message}");
                throw;
            }
            
        }

        /// <summary>
        /// Endpoint para Listar os Jogos
        /// </summary>
        /// <returns></returns>
        [HttpGet("Listar-Jogo")]

        public List<Jogo> ListarJogo()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao Listar os Jogos, " +
                    $"o erro foi \n {erro.Message}"); 
            }
            
        }

        /// <summary>
        /// Endpoint para Remover um Jogo
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Remover-Jogo")]

        public IActionResult DeletarJogo(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();    
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao Remover um Jogo, " +
                   $"o erro foi \n {erro.Message}"); 
            }
            
        }

        /// <summary>
        /// Endpoint para Editar um Jogo
        /// </summary>
        /// <param name="Jogo"></param>
        [HttpPut("Editar-Jogo")]

        public IActionResult EditarJogo(Jogo Jogo)
        {
            try
            {
                _service.Editar(Jogo);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao Editar um Jogo, " +
                  $"o erro foi \n {erro.Message}"); 
            }
            
        }

        /// <summary>
        /// Endpoint para Buscar um Jogo por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Buscar-Jogo-por-Id")]

        public Jogo BuscarPorId(int id)
        {
            try
            {
                return _service.BuscarJogoPorId(id);
            }
            catch (Exception erro)
            {
                throw new Exception($"Ocorreu um erro ao Buscar um Jogo por Id, " +
                  $"o erro foi \n {erro.Message}");
            }
            
        }
    }
}

