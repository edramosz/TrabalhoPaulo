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
        public readonly string _connectionString;
        private readonly IMapper _mapper;

        public JogoController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new JogoService(connectionString);
            _mapper = mapper;
        }

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

