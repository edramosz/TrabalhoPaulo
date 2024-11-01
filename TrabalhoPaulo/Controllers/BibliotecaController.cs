using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        //private IBibliotecaService _service;
        //public readonly string _connectionString;
        //private readonly IMapper _mapper;

        //public BibliotecaController(IMapper mapper, IConfiguration config)
        //{
        //    string connectionString = config.GetConnectionString("DefaultConnection");
        //    _service = new BibliotecaService(connectionString);
        //    _mapper = mapper;
        //}

        //[HttpPost("Adicionar-Biblioteca")]

        //public void AdicionarBiblioteca(Biblioteca j)
        //{
        //    _service.Adicionar(j);
        //}
        //[HttpGet("Listar-Biblioteca")]

        //public List<Biblioteca> ListarBiblioteca()
        //{
        //    return _service.Listar();
        //}

        //[HttpDelete("Remover-Biblioteca")]

        //public void DeletarBiblioteca(int id)
        //{
        //    _service.Remover(id);
        //}

        //[HttpPut("Editar-Biblioteca")]

        //public void EditarBiblioteca(Biblioteca Biblioteca)
        //{
        //    _service.Editar(Biblioteca);
        //}

        //[HttpGet("Buscar-Biblioteca-por-Id")]

        //public Biblioteca BuscarPorId(int id)
        //{
        //    return _service.BuscarBibliotecaPorId(id);
        //}
    }
}
