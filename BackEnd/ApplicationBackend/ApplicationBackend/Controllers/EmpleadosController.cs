using Microsoft.AspNetCore.Mvc;
using ApplicationBackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json.Serialization;

namespace ApplicationBackend.Controllers
{
    [ApiController]
    [Route("apirrhh/empleados")]
    public class EmpleadosController : ControllerBase
    {
        [HttpGet]
        [Route("get-empleados")]
        public async Task<IActionResult> GetEmpleados()
        {
            var empleados = new List<object>
            {
                new { EmpleadoId = "1", Nombre = "Juan", Apellido = "Pérez", Edad = 30 },
                new { EmpleadoId = "2", Nombre = "María", Apellido = "Gómez", Edad = 25 }
            };
            return Ok(empleados);
        }

        [HttpPost]
        [Route("add-empleado")]
        public async Task<IActionResult> AddEmpleado()
        {
            return Ok();
        }

        [HttpPut]
        [Route("update-empleado")]
        public async Task<IActionResult> UpdateEmpleado()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("delete-empleado/{id}")]
        public async Task<IActionResult> DeleteEmpleado()
        {
            return Ok();
        }
    }
}
