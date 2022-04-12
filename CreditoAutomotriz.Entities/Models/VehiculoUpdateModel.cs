using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Entities.Models
{
    public class VehiculoUpdateModel
    {
        /// <summary>
        /// idAuto
        /// </summary>
        [Required(ErrorMessage = "Campo idAuto requerido")]
        [JsonProperty(PropertyName = "idAuto")]
        public int idAuto { get; set; }

        /// <summary>
        /// Placa del auto
        /// </summary>
        [Required(ErrorMessage = "Campo placa requerido")]
        [JsonProperty(PropertyName = "placa")]
        public string placa { get; set; }

        /// <summary>
        /// modelo del Vehiculo
        /// </summary>
        [Required(ErrorMessage = "Campo modelo requerido")]
        [JsonProperty(PropertyName = "modelo")]
        public string modelo { get; set; }

        /// <summary>
        /// nroChasis del Vehiculo
        /// </summary>
        [Required(ErrorMessage = "nroChasis requerido")]
        [JsonProperty(PropertyName = "nroChasis")]
        public string nroChasis { get; set; }

        /// <summary>
        /// IdMarca
        /// </summary>
        [Required(ErrorMessage = "Campo idMarca requerido")]
        [JsonProperty(PropertyName = "idMarca")]
        public int idMarca { get; set; }

        /// <summary>
        /// tipo del Vehiculo
        /// </summary>
        [Required(ErrorMessage = "tipo requerido")]
        [JsonProperty(PropertyName = "tipo")]
        public string tipo { get; set; }

        /// <summary>
        /// cilindraje del Vehiculo
        /// </summary>
        [Required(ErrorMessage = "cilindraje requerido")]
        [JsonProperty(PropertyName = "cilindraje")]
        public string cilindraje { get; set; }

        /// <summary>
        /// avaluo del Patio
        /// </summary>
        [Required(ErrorMessage = "avaluo requerido")]
        [JsonProperty(PropertyName = "avaluo")]
        public decimal avaluo { get; set; }

        /// <summary>
        /// idPatio
        /// </summary>
        [Required(ErrorMessage = "Campo idPatio requerido")]
        [JsonProperty(PropertyName = "idPatio")]
        public int idPatio { get; set; }


    }
}
