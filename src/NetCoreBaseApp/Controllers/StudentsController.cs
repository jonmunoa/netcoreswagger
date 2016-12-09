using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCoreBaseApp.Controllers
{
    /// <summary>
    /// Esta clase se usa como CRUD de la entidad alumno
    /// </summary>
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        /// <summary>
        /// Este método devuelve una lista de alumnos
        /// </summary>
        /// <returns>Lista de alumnos</returns>
        [SwaggerResponse(200, Description = "Lista de alumnos devuelta", Type = typeof(IEnumerable<string>))]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Alumno 1", "Alumno 2" });
        }

        /// <summary>
        /// Crea un alumno
        /// </summary>
        /// <param name="alumno">Nombre del alumno</param>
        [SwaggerResponse(201, Description = "Alumno creado", Type = typeof(string))]
        [HttpPost]
        public IActionResult Post([FromBody]string alumno)
        {
            return Ok();
        }
    }
}