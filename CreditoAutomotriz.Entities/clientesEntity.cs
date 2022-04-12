using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CreditoAutomotriz.Entities
{

    [Keyless]
    public class clientesEntity
    {
        [Key]
        public int idCliente { get; set; }
        public string identificacion { get; set; }

        public string nombres { get; set; }

        public string edad { get; set; }
        public string fechaNacimiento { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string estadoCivil { get; set; }
        public string identificacionConyugue { get; set; }
        public string nombreConyugue { get; set; }
        public string sujetoCredito { get; set; }

    }


}