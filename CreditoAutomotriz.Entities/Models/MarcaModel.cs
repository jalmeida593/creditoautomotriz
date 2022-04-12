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
    public class MarcaModel
    {
        [Key]
        /// <summary>
        /// Id de Marca
        /// </summary>
        [Required(ErrorMessage = "Campo idMarca requerido")]
        [JsonProperty(PropertyName = "idMarca")]
        public int idMarca { get; set; }

        /// <summary>
        /// descripcion de la marca
        /// </summary>
        [Required(ErrorMessage = "Campo descripcion requerido")]
        [JsonProperty(PropertyName = "descripcion")]
        public string descripcion { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required(ErrorMessage = "Campo Estado requerido")]
        [JsonProperty(PropertyName = "Estado")]
        public int estado { get; set; }
    }
}
