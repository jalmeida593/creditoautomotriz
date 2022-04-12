using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Entities
{
    [Keyless]
    public class VehiculosEntity
    {
        [Key]
        public int idAuto { get; set; }
        public string placa { get; set; }

        public string modelo { get; set; }
        public string nroChasis { get; set; }
        public int idMarca { get; set; }
        public string tipo { get; set; }
        public string cilindraje { get; set; }
        public string avaluo { get; set; }
        public int idPatio { get; set; }
    }
}
