using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para la carga Clientes.
    /// </summary>
    [Route("api/Ejecutivos")]
    [ApiController]
    public class CargaEjecutivosController : ControllerBase
    {
        private readonly IEjecutivoService _EjecutivoService;
        public CargaEjecutivosController(IEjecutivoService iejecutivoService)
        {
            _EjecutivoService = iejecutivoService;
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

                var data = _EjecutivoService.leerData(filePaths);
                return Ok(_EjecutivoService.guardarData(data));
            }

            return BadRequest("File incorrect extension");
        }
    }
}
