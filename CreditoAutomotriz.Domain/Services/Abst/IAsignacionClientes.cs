using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface IAsignacionClientes
    {
        bool asignarCliente(AsignacionClienteModel cliente);
    }
}
