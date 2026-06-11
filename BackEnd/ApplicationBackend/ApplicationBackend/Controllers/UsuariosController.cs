using Microsoft.AspNetCore.Mvc;
using ApplicationBackend.Models;
using ApplicationBackend.Data.Repositories;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("apirrhh/usuarios")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        [Route("validar-user")]
        public async Task<IActionResult> SesionUser()
        {
            var repo = new RepositoryUsuarios();
            var usuario = repo.ValidarUsuario();
            return Ok(usuario);
        }
    }
}
