using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private IEnderecoService _service;
        public readonly string _connectionString;
        private readonly IMapper _mapper;

        public EnderecoController(IMapper mapper, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new EnderecoService(connectionString);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Endereco")]

        public void AdicionarEndereco(Endereco e)
        {
            _service.Adicionar(e);
        }
        [HttpGet("Listar-Endereco")]

        public List<Endereco> ListarEndereco()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Endereco")]

        public void DeletarEndereco(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Endereco")]

        public void EditarEndereco(Endereco Endereco)
        {
            _service.Editar(Endereco);
        }

        [HttpGet("Buscar-Endereco-por-Id")]

        public Endereco BuscarPorId(int id)
        {
            return _service.BuscarEnderecoPorId(id);
        }
    }
}