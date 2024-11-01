using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private ICarrinhoService _service;
        public readonly string _connectionString;
        //private readonly IMapper _mapper;

        public CarrinhoController(IConfiguration config)//,IMapper mapper,)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            _service = new CarrinhoService(connectionString);
            //_mapper = mapper;
        }

        [HttpPost("Adicionar-Carrinho")]

        public void AdicionarCarrinho(Carrinho j)
        {
            _service.Adicionar(j);
        }
        [HttpGet("Listar-Carrinho")]

        public List<Carrinho> ListarCarrinho()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Carrinho")]

        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Carrinho")]

        public void EditarCarrinho(Carrinho Carrinho)
        {
            _service.Editar(Carrinho);
        }

        [HttpGet("Buscar-Carrinho-por-Id")]

        public Carrinho BuscarPorId(int id)
        {
            return _service.BuscarCarrinhoPorId(id);
        }
    }
}
