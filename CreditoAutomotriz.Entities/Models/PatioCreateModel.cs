using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Entities.Models
{
    [Keyless]
    public class PatioCreateModel
    {
        [Key]
        /// <summary>
        /// Id del Patio
        /// </summary>
        [Required(ErrorMessage = "Campo Id requerido")]
        [JsonProperty(PropertyName = "Id")]
        public int idPatio { get; set; }

        /// <summary>
        /// Nombre del Patio
        /// </summary>
        [Required(ErrorMessage = "Campo Nombre requerido")]
        [JsonProperty(PropertyName = "Nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Dirección del Patio
        /// </summary>
        [Required(ErrorMessage = "Campo Dirección requerido")]
        [JsonProperty(PropertyName = "Direccion")]
        public string Direccion { get; set; }

        /// <summary>
        /// Teléfono del Patio
        /// </summary>
        [Required(ErrorMessage = "Teléfono requerido")]
        [JsonProperty(PropertyName = "Telefono")]
        public string Telefono { get; set; }

        /// <summary>
        /// Punto de Venta
        /// </summary>
        [JsonProperty(PropertyName = "puntoVenta")]
        public string puntoVenta { get; set; }

        

    }
}
