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
                new Persona() { Nombre = "Erica", Edad = 09 },
                new Persona() { Nombre = "Elizabeth", Edad = 15 }
            };

        [HttpGet]
        public List<Persona> Get()
        {
            return p;
        }

        //https://localhost:7126/api/persona/Diego
        //se manda el parametro a eliminar desde la URL
        [HttpDelete("{nombre}")]
        public ActionResult Delete(string nombre)
        {
            Persona? eliminar = p.Where(p => p.Nombre == nombre).FirstOrDefault();
            if(eliminar == null) return NoContent();
            p.Remove(eliminar);
            return NoContent();
        }

        //se envia los parametros desde el Body
        //con el formato JSON
        [HttpPost]
        public ActionResult Post([FromBody] Persona persona)
        {
            
            var objeto = persona;
            p.Add(objeto);
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put(string nombre, [FromBody] Persona persona)
        {
            var objeto = persona;
            p.Where(x => x.Nombre.Equals(nombre));
            //no hay como hacerlo desde un CollecctionGeneric, esto se hace desde una base de datos
            return NoContent();
        }




    }
}
