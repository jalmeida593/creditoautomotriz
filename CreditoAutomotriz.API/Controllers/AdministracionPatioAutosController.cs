using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para la Administracion Patios de Autos.
    /// </summary>
    [Route("api/AdminAutos")]
    [ApiController]
    public class AdministracionPatioAutosController : ControllerBase
    {
        private readonly IPatioAutoService _patioService;
        public AdministracionPatioAutosController(IPatioAutoService patioService)
        {
            _patioService = patioService;
        }
        /// <summary>
        /// Servicio para buscar Patio por Id
        /// </summary>
        /// <param name="idPatio"> id del Patio</param>
        /// <returns></returns>
        [Route("{idPatio}")]
        [HttpGet]
        public IActionResult buscarporId(int idPatio)
        {
            return Ok(_patioService.buscarPatio(idPatio));
        }
        /// <summary>
        /// Servicio para todos los Patios 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult buscarPatios()
        {
            return Ok(_patioService.buscarPatios());
        }

        /// <summary>
        /// Creacion de un Patio
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ingresarPatio(PatioCreateModel Patio)
        {
            return Ok(_patioService.Insert(Patio));

        }

        /// <summary>
        /// Actualización de un Patio
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ActualizarPatio(PatioCreateModel Patio)
        {
            return Ok(_patioService.actualizarPatio(Patio));

        }

        /// <summary>
        /// Servicio para eliminar un Patio por Id
        /// </summary>
        /// <param name="idPatio"> id del Patio</param>
        /// <returns></returns>
        [Route("{idPatio}")]
        [HttpDelete]
        public IActionResult eliminarporId(int idPatio)
        {
            return Ok(_patioService.eliminarPatio(idPatio));
        }
    }
}
