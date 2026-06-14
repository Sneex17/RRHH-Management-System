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
        [Route("validar-user/{user}/{pass}")]
        public async Task<IActionResult> SesionUser(string user, string pass)
        {
            var repo = new RepositoryUsuarios();
            var usuario = repo.ValidarUsuario(user, pass);
            return Ok(usuario);
        }
    }
}
