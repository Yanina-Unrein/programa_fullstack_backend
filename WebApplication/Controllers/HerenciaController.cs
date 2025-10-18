using Microsoft.AspNetCore.Mvc;
using WebApplication1.EjemploHerencia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Controlador para gestionar clientes y proveedores
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploHerenciaController : ControllerBase
    {
        /// <summary>
        /// Obtiene el número de cliente de un cliente de ejemplo
        /// </summary>
        /// <returns>Número de cliente</returns>
        /// <response code="200">Devuelve el número de cliente</response>
        [HttpGet("cliente")]
        public IActionResult GetNumeroCliente()
        {
            var cliente = new Cliente("Juan", "Pérez", "35534321", 1001);
            return Ok(new { NumeroCliente = cliente.NumeroCliente });
        }

        /// <summary>
        /// Obtiene el número de proveedor de un proveedor de ejemplo
        /// </summary>
        /// <returns>Número de proveedor</returns>
        /// <response code="200">Devuelve el número de proveedor</response>
        [HttpGet("proveedor")]
        public IActionResult GetNumeroProveedor()
        {
            var proveedor = new Proveedor("Carlos", "Gómez", "40000000", "P-200");
            return Ok(new { NumeroProveedor = proveedor.NumeroProveedor });
        }
    }
}
