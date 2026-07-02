using Microsoft.AspNetCore.Mvc;
using ApplicationBackend.Data.Repositories;
using Newtonsoft.Json;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("sexos")]
    public class SexoController : ControllerBase
    {
        [HttpGet]
        [Route("lista-sexos")]
        public async Task<IActionResult> GetSexos()
        {
            var repositorySexo = new RepositorySexos();
            var listaSexos = JsonConvert.SerializeObject(repositorySexo.Lista());
            return Ok(listaSexos);
        }
    }
}
