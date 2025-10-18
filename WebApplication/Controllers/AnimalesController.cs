using Microsoft.AspNetCore.Mvc;
using WebApplication1.EjemploInterfaz;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalesController : ControllerBase
    {
        [HttpGet("perro")]
        public IActionResult GetPerro()
        {
            IAnimal perro = new Perro("Firulais");
            return Ok(new { Nombre = perro.Nombre, Sonido = perro.HacerSonido() });
        }

        [HttpGet("gato")]
        public IActionResult GetGato()
        {
            IAnimal gato = new Gato("Michi");
            return Ok(new { Nombre = gato.Nombre, Sonido = gato.HacerSonido() });
        }
    }
}
