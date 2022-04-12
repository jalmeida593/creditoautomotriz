using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Domain.Services.Abst;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para la carga Clientes.
    /// </summary>
    [Route("api/Clientes")]
    [ApiController]
    public class CargaClientesController : ControllerBase
    {
        private readonly IclienteService _clienteService;
        public CargaClientesController(IclienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Cargar archivo a una ruta en específico
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        /// <response code="200">Success </response>
        /// <response code="500">Internal Server Error</response>
        [Route("UploadFiles")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorEntity))]
        public async Task<ActionResult> guardarDocs(IFormFile formFile)
        {
            if (formFile == null || formFile.Length == 0)
                return Content("File Not Selected");

            string fileExtension = Path.GetExtension(formFile.FileName);

            if (fileExtension == ".csv")
            {
                var rootFolders = "//localhost/Users/Jonat/Desktop/UploadedFiles";
                var fileNames = formFile.FileName;
                var filePaths = Path.Combine(rootFolders, fileNames);
                var fileLocation = new FileInfo(filePaths);

                using (var stream = new FileStream(filePaths, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                if (formFile.Length <= 0)
                    return BadRequest("File no Found");

                var data = _clienteService.leerData(filePaths);
                return Ok(_clienteService.guardarData(data));
            }

            return BadRequest("File incorrect extension");
        }

    }
}
