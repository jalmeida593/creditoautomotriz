using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para la Administracion Vehiculos.
    /// </summary>
    [Route("api/Vehiculos")]
    [ApiController]
    public class AdministracionVehiculosController : Controller
    {
        private readonly IVehiculoService _vehiculoService;
        public AdministracionVehiculosController(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        /// <summary>
        /// Servicio para buscar Vehiculo por Id
        /// </summary>
        /// <param name="idVehiculo"> id del Vehiculo</param>
        /// <returns></returns>
        [Route("{idVehiculo}")]
        [HttpGet]
        public IActionResult buscarporId(int idVehiculo)
        {
            return Ok(_vehiculoService.buscarVehiculo(idVehiculo));
        }
        /// <summary>
        /// Servicio para todos los Vehiculos 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult buscarVehiculos()
        {
            return Ok(_vehiculoService.buscarVehiculos());
        }

        /// <summary>
        /// Creacion de un Vehiculo
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ingresarVehiculo(VehiculoCreateModel Vehiculo)
        {
            return Ok(_vehiculoService.crearVehiculo(Vehiculo));

        }

        /// <summary>
        /// Actualización de un Vehiculo
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ActualizarVehiculo(VehiculoCreateModel Vehiculo)
        {
            return Ok(_vehiculoService.actualizarVehiculo(Vehiculo));

        }

        /// <summary>
        /// Servicio para eliminar un Vehiculo por Id
        /// </summary>
        /// <param name="idVehiculo"> id del Vehiculo</param>
        /// <returns></returns>
        [Route("{idVehiculo}")]
        [HttpDelete]
        public IActionResult eliminarporId(int idVehiculo)
        {
            return Ok(_vehiculoService.eliminarVehiculo(idVehiculo));
        }

    }
}
