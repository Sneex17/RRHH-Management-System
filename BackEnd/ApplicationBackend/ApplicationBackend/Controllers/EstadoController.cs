using ApplicationBackend.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("estados")]
    public class EstadoController : ControllerBase
    {
        [HttpGet]
        [Route("lista-estados")]
        public async Task<IActionResult> GetEstados()
        {
            var repository = new RepositoryEstados();
            var listaEstados = JsonConvert.SerializeObject(repository.Lista());
            return Ok(listaEstados);     
        }
    }
}
