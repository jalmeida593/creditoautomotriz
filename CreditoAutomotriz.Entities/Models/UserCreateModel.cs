using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Entities.Models
{
    public class UserCreateModel
    {
        /// <summary>
        /// Id del cliente
        /// </summary>
        [JsonProperty(PropertyName = "identificacion")]
        public int idCliente { get; set; }
        /// <summary>
        /// identificacion del cliente
        /// </summary>
        [Required(ErrorMessage = "Campo identificacion requerido")]
        [JsonProperty(PropertyName = "identificacion")]
        public string identificacion { get; set; }

        /// <summary>
        /// Nombres del cliente
        /// </summary>
        [Required(ErrorMessage = "Campo nombres requerido")]
        [JsonProperty(PropertyName = "nombres")]
        public string nombres { get; set; }

        /// <summary>
        /// Apellidos del cliente
        /// </summary>
        [Required(ErrorMessage = "Apellidos requeridos")]
        [JsonProperty(PropertyName = "apellidos")]
        public string apellidos { get; set; }

        /// <summary>
        /// Fecha de Nacimiento del cliente
        /// </summary>
        [JsonProperty(PropertyName = "fechaNacimiento")]
        public DateTime fechaNacimiento { get; set; }

        /// <summary>
        /// edad del cliente
        /// </summary>
        [JsonProperty(PropertyName = "edad")]
        public int edad { get; set; }

        /// <summary>
        /// Direccion del cliente
        /// </summary>
        [JsonProperty(PropertyName = "Direccion")]
        public string direccion { get; set; }

        /// <summary>
        /// Telefono del cliente
        /// </summary>
        [JsonProperty(PropertyName = "Telefono")]
        public string telefono { get; set; }

        /// <summary>
        /// Estado Civil del cliente
        /// </summary>
        [JsonProperty(PropertyName = "estadoCivil")]
        public string estadoCivil { get; set; }

        /// <summary>
        /// Identificacion Conyugue del cliente
        /// </summary>
        [JsonProperty(PropertyName = "identificacionConyugue")]
        public string ?identificacionConyugue { get; set; }

        /// <summary>
        /// Nombre del Conyugue del cliente
        /// </summary>
        [JsonProperty(PropertyName = "nombreConyugue")]
        public string ?nombreConyugue { get; set; }

        /// <summary>
        /// Es Sujeto Credito?
        /// </summary>
        [JsonProperty(PropertyName = "sujetoCredito")]
        public string sujetoCredito { get; set; }

    }
}
