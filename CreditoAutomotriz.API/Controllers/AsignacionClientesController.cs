using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Credito_Automotriz.Controllers
{
    public class AsignacionClientesController : ControllerBase
    {
        private readonly IAsignacionClientes _asignacionService;
        public AsignacionClientesController(IAsignacionClientes clienteService)
        {
            _asignacionService = clienteService;
        }
        /// <summary>
        /// Asignación de un Cliente a un Patio
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> ingresarAsignacionCliente(AsignacionClienteModel cliente)
        {
            return Ok(_asignacionService.asignarCliente(cliente));
        }

    }
}
