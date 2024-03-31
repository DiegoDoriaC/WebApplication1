using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        public List<Persona> Persona()
        {
            List<Persona> p = new List<Persona>
            {
                new Persona() { Nombre = "Diego", Edad = 21 },
                new Persona() { Nombre = "Javier", Edad = 25 },
                new Persona() { Nombre = "Erica", Edad = 10 },
            };
            return p;
        }
    }
}
