using AutoMapper;
using Core._01_Services.Interfaces;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using Core._03_Entidades.DTOs;

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

        /// <summary>
        /// Endpoint para Adicionar usuario
        /// </summary>
        /// <param name="u"></param>
        /// 
        [HttpPost("Adicionar-Usuario")]

        public void AdicionarUsuario(Usuario u)
        {
            _service.Adicionar(u);
        }

        /// <summary>
        /// Endpoint para Listar Usuarios
        /// </summary>

        [HttpGet("Listar-Usuario")]

        public List<Usuario> ListarUsuario()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Endpoint para remover um usuario por id
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete("Remover-Usuario")]

        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }

        /// <summary>
        /// Endpoint para editar um Usuario
        /// </summary>
        /// <param name="Usuario"></param>

        [HttpPut("Editar-Usuario")]

        public void EditarUsuario(Usuario Usuario)
        {
            _service.Editar(Usuario);
        }

        /// <summary>
        /// Endpoint para Buscar um usuario por id
        /// </summary>
        /// <param name="id"></param>

        [HttpGet("Buscar-Usuario-por-Id")]

        public Usuario BuscarPorId(int id)
        {
            return _service.BuscarUsuarioPorId(id);
        }

        /// <summary>
        /// Endpoint para usuario fazer login
        /// </summary>
        /// <param name="usuarioLogin"></param>
        /// 
        [HttpPost("fazer-login")]
        public Usuario FazerLogin(UsuarioLoginDTO usuarioLogin)
        {
            Usuario usuario = _service.FazerLogin(usuarioLogin);
            return usuario;
        }
    }
}

