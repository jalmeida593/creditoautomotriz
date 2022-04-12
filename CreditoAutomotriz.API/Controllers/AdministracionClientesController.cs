using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para la Administracion Clientes.
    /// </summary>
    [Route("api/AdminClientes")]
    [ApiController]
    public class AdministracionClientesController : ControllerBase
    {
        private readonly IclienteService _clienteService;
        public AdministracionClientesController(IclienteService clienteService)
        {
            _clienteService = clienteService;
        }
        /// <summary>
        /// Servicio para buscar Cliente por Id
        /// </summary>
        /// <param name="idCliente"> id del Cliente</param>
        /// <returns></returns>
        [Route("{idCliente}")]
        [HttpGet]
        public IActionResult buscarporId(int idCliente)
        {
            return Ok(_clienteService.buscarCliente(idCliente));
        }
        /// <summary>
        /// Servicio para todos los clientes 
        /// </summary>
        /// <returns></returns>
       
        [HttpGet]
        public IActionResult buscarClientes()
        {
            return Ok(_clienteService.buscarClientes());
        }

        /// <summary>
        /// Creacion de un Cliente
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ingresarCliente(UserCreateModel cliente)
        {
            return Ok(_clienteService.crearCliente(cliente));
        }

        /// <summary>
        /// Actualización de un Cliente
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ActualizarCliente(UserCreateModel cliente)
        {
            return Ok(_clienteService.actualizarCliente(cliente));
            
        }

        /// <summary>
        /// Servicio para eliminar un Cliente por Id
        /// </summary>
        /// <param name="idCliente"> id del Cliente</param>
        /// <returns></returns>
        [Route("{idCliente}")]
        [HttpDelete]
        public IActionResult eliminarporId(int idCliente)
        {
            return Ok(_clienteService.eliminarCliente(idCliente));
        }
    }
}
