using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CAccesoDatos.Data.Repositories;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("departamentos")]
    public class DepartamentoController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        public async Task<IActionResult> GetDepartamentos()
        {
            var repository = new RepositoryDepartamentos();
            var listaDepartamentos = JsonConvert.SerializeObject(repository.Lista());
            return Ok(listaDepartamentos);
        }
    }

}
