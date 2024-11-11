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
        //private readonly IMapper _mapper;

        public CarrinhoController(ICarrinhoService repos)//,IMapper mapper,)
        {
            _service = repos;
            //_mapper = mapper;
        }

        /// <summary>
        /// Endpoint para adicionar um carrinho
        /// </summary>
        /// <param name="car"></param>
        [HttpPost("Adicionar-Carrinho")]

        public void AdicionarCarrinho(Carrinho car)
        {
            _service.Adicionar(car);
        }
        /// <summary>
        /// Endpoint para listar carrinhos
        /// </summary>
        /// <returns></returns>
        [HttpGet("Listar-Carrinho")]

        public List<Carrinho> ListarCarrinho()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Endpoint para Remover um Carrinho
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Remover-Carrinho")]

        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }

        /// <summary>
        /// Endpoint para Editar um Carrinho
        /// </summary>
        /// <param name="Carrinho"></param>
        [HttpPut("Editar-Carrinho")]

        public void EditarCarrinho(Carrinho Carrinho)
        {
            _service.Editar(Carrinho);
        }

        /// <summary>
        /// Endpoint para listar um carrinho pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Buscar-Carrinho-por-Id")]

        public Carrinho BuscarPorId(int id)
        {
            return _service.BuscarCarrinhoPorId(id);
        }
    }
}
