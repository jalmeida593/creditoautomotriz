using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credito_Automotriz.Controllers
{
    /// <summary>
    /// Controlador para Marcas.
    /// </summary>
    [Route("api/Marcas")]
    [ApiController]
    public class CargaMarcasController : ControllerBase
    {
        private readonly ImarcasService _marcasService;
        public CargaMarcasController(ImarcasService marcasService)
        {
            _marcasService = marcasService;
        }
        /// <summary>
        /// Cargar archivo de marcas a una ruta en específico
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
        public async Task<ActionResult> guardarDocsMarca(IFormFile formFile)
        {
            if (formFile == null || formFile.Length == 0)
                return Content("File Not Selected");

            string fileExtension = Path.GetExtension(formFile.FileName);

            if (fileExtension == ".csv")
            {
                var rootFolders = "//localhost/Users/Jonat/Desktop/UploadedFiles/Marcas";
                var fileNames = formFile.FileName;
                var filePaths = Path.Combine(rootFolders, fileNames);
                var fileLocation = new FileInfo(filePaths);

                using (var stream = new FileStream(filePaths, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                if (formFile.Length <= 0)
                    return BadRequest("File no Found");

                var data = _marcasService.leerData(filePaths);
                var igualar = _marcasService.igualarData(data);
                return Ok(_marcasService.guardarData(igualar));
            }

            return BadRequest("File incorrect extension");
        }
    }
}
