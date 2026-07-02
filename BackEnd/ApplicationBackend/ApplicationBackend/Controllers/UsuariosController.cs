using CAccesoDatos.Data.Repositories;
using CEntidades.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using CAccesoDatos.DTOs;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("apirrhh/usuarios")]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        [Route("validar-user")]
        public async Task<IActionResult> SesionUser([FromBody] LoginUsuarioDTO usuario)
        {
            if (usuario == null) return BadRequest("El modelo llegó nulo");
            var repo = new RepositoryUsuarios();
            var usuarioExiste = repo.ValidarUsuario(usuario);
            return Ok(usuarioExiste);
        }
    }
}
