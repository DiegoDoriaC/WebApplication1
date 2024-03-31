using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private static List<Persona> p = new List<Persona>
            {
                new Persona() { Nombre = "Diego", Edad = 21 },
                new Persona() { Nombre = "Javier", Edad = 25 },
                new Persona() { Nombre = "Erica", Edad = 10 },
            };

        [HttpGet]
        public List<Persona> Get()
        {
            return p;
        }

        [HttpDelete("{nombre}")]
        public ActionResult Delete(string nombre)
        {
            Persona? eliminar = p.Where(p => p.Nombre == nombre).FirstOrDefault();
            p.Remove(eliminar);
            return NoContent();
        }



    }
}
