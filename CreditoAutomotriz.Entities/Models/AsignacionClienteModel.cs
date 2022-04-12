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
    public class AsignacionClienteModel
    {
        [Key]
        /// <summary>
        /// Id de idPatioCliente
        /// </summary>
        [JsonProperty(PropertyName = "idPatioCliente")]
        public int idPatioCliente { get; set; }

        /// <summary>
        /// idPatio 
        /// </summary>
        [Required(ErrorMessage = "Campo idPatio requerido")]
        [JsonProperty(PropertyName = "idPatio")]
        public int idPatio { get; set; }

        /// <summary>
        /// idCliente
        /// </summary>
        [Required(ErrorMessage = "Campo idCliente requerido")]
        [JsonProperty(PropertyName = "idCliente")]
        public int idCliente { get; set; }

        /// <summary>
        /// fechaAsignacion
        /// </summary>
        [Required(ErrorMessage = "Campo fechaAsignacion requerido")]
        [JsonProperty(PropertyName = "fechaAsignacion")]
        public DateTime fechaAsignacion { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [JsonProperty(PropertyName = "estado")]
        public int estado { get; set; }
    }
}
