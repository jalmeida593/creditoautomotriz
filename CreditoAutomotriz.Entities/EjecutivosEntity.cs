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
    public class EjecutivosEntity
    {
        [Key]
        public int idEmpleado { get; set; }
        public string identificacion { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string idPatio { get; set; }
        public string edad { get; set; }
        

    }
}
