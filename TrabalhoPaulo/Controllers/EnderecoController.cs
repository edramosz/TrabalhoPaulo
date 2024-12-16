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
        //private readonly IMapper _mapper;

        public EnderecoController(IEnderecoService serv)//,IMapper mapper)
        {
            _service = serv;
            //_mapper = mapper;
        }

        /// <summary>
        /// Endpoint para Adicionar um Endereço
        /// </summary>
        /// <param name="e"></param>

        [HttpPost("Adicionar-Endereco")]

        public void AdicionarEndereco(Endereco e)
        {
            _service.Adicionar(e);
        }

        /// <summary>
        /// Endpoint para Listar os endereços
        /// </summary>
        /// 
        [HttpGet("Listar-Endereco")]

        public List<Endereco> ListarEndereco()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Endpoint para remover um endereço
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete("Remover-Endereco")]

        public void DeletarEndereco(int id)
        {
            _service.Remover(id);
        }

        /// <summary>
        /// Endpoint para editar um endereço
        /// </summary>
        /// <param name="id"></param>

        [HttpPut("Editar-Endereco")]

        public void EditarEndereco(Endereco Endereco)
        {
            _service.Editar(Endereco);
        }

        /// <summary>
        /// Endpoint para Buscar um endereço por id
        /// </summary>
        /// <param name="id"></param>

        [HttpGet("Buscar-Endereco-por-Id")]

        public Endereco BuscarPorId(int id)
        {
            return _service.BuscarEnderecoPorId(id);
        }
    }
}