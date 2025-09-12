using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Controlador para gestionar instrumentos musicales
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        /// <summary>
        /// Obtiene todos los instrumentos disponibles
        /// </summary>
        /// <returns>Lista de todos los instrumentos</returns>
        /// <response code="200">Devuelve la lista de instrumentos</response>
        // GET: api/instruments
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return InstrumentRepository.Instruments;
        }

        /// <summary>
        /// Agrega un nuevo instrumento a la lista
        /// </summary>
        /// <param name="instrumentName">Nombre del instrumento a agregar</param>
        /// <returns>Mensaje de confirmación</returns>
        /// <response code="200">Instrumento agregado exitosamente</response>
        /// <response code="400">Si el nombre está vacío o es nulo</response>
        // POST: api/instruments
        [HttpPost]
        public ActionResult<string> Post([FromBody] string instrument)
        {
            if (string.IsNullOrWhiteSpace(instrument))
            {
                return BadRequest("El nombre del instrumento no puede estar vacío.");
            }

            InstrumentRepository.Instruments.Add(instrument);
            return Ok($"Instrumento agregado: {instrument}");
        }

        /// <summary>
        /// Actualiza el nombre de un instrumento existente
        /// </summary>
        /// <param name="index">Posición del instrumento en la lista (0-based)</param>
        /// <param name="newName">Nuevo nombre para el instrumento</param>
        /// <returns>Mensaje de confirmación con el cambio realizado</returns>
        /// <response code="200">Instrumento actualizado exitosamente</response>
        /// <response code="400">Si el índice es inválido o el nombre está vacío</response>
        // PUT: api/instruments/{index}
        [HttpPut("{index}")]
        public ActionResult<string> Put(int index, [FromBody] string newName)
        {
            if (index < 0 || index >= InstrumentRepository.Instruments.Count)
            {
                return BadRequest($"Índice {index} no válido. La lista tiene {InstrumentRepository.Instruments.Count} elementos");
            }

            string oldName = InstrumentRepository.Instruments[index];
            InstrumentRepository.Instruments[index] = newName;
            return Ok($"Instrumento en posición {index} actualizado de '{oldName}' a: {newName}");
        }

        /// <summary>
        /// Elimina un instrumento de la lista
        /// </summary>
        /// <param name="index">Posición del instrumento a eliminar (0-based)</param>
        /// <returns>Mensaje con el nombre del instrumento eliminado</returns>
        /// <response code="200">Instrumento eliminado exitosamente</response>
        /// <response code="400">Si el índice es inválido</response>
        // DELETE: api/instruments/{index}
        [HttpDelete("{index}")]
        public IActionResult DeleteInstrument(int index)
        {
            if (index < 0 || index >= InstrumentRepository.Instruments.Count)
            {
                return BadRequest($"Índice {index} no válido. La lista tiene {InstrumentRepository.Instruments.Count} elementos");
            }

            string deletedInstrument = InstrumentRepository.Instruments[index];
            InstrumentRepository.Instruments.RemoveAt(index);

            return Ok($"Instrumento eliminado: {deletedInstrument}");
        }
    }
}
