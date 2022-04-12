using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CreditoAutomotriz.Entities
{
    [Keyless]
    public class MarcasEntity
    {
        [Key]
        public int idMarca { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

    }
}
