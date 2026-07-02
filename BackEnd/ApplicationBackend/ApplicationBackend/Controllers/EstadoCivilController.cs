using CAccesoDatos.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("estadosCiviles")]
    public class EstadoCivilController : ControllerBase
    {
        [HttpGet]
        [Route("lista-estadoCivil")]
        public async Task<IActionResult> GetEstadosCiviles()
        {
            var repository = new RepositoryEstadosCiviles();
            var listaEstadoCivil = JsonConvert.SerializeObject(repository.Lista());
            return Ok(listaEstadoCivil);
        }
    }
}
