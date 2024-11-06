using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private IVendaService _service;
        //private readonly IMapper _mapper;

        public VendaController(IVendaService serv)//,IMapper mapper)
        {
            _service = serv;
            //_mapper = mapper;
        }

        [HttpPost("Adicionar-Venda")]

        public void AdicionarVenda(Venda v)
        {
            _service.Adicionar(v);
        }
        [HttpGet("Listar-Venda")]

        public List<Venda> ListarVenda()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Venda")]

        public void DeletarVenda(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Venda")]

        public void EditarVenda(Venda venda)
        {
            _service.Editar(venda);
        }

        [HttpGet("Buscar-Venda-por-Id")]

        public Venda BuscarPorId(int id)
        {
            return _service.BuscarVendaPorId(id);
        }
    }
}
    
