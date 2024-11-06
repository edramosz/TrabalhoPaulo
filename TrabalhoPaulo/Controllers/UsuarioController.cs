using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _service;
        //private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService serv)//,IMapper mapper)
        {
            _service = serv;
            //_mapper = mapper;
        }

        [HttpPost("Adicionar-Usuario")]

        public void AdicionarUsuario(Usuario u)
        {
            _service.Adicionar(u);
        }
        [HttpGet("Listar-Usuario")]

        public List<Usuario> ListarUsuario()
        {
            return _service.Listar();
        }

        [HttpDelete("Remover-Usuario")]

        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }

        [HttpPut("Editar-Usuario")]

        public void EditarUsuario(Usuario Usuario)
        {
            _service.Editar(Usuario);
        }

        [HttpGet("Buscar-Usuario-por-Id")]

        public Usuario BuscarPorId(int id)
        {
            return _service.BuscarUsuarioPorId(id);
        }
    }
}

