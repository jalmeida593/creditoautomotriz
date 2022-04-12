using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class AsignacionClientes : IAsignacionClientes
    {
        private readonly IAsignacionClientesRepository _asignacionServiceRepo;
        public AsignacionClientes(IAsignacionClientesRepository clienteService)
        {
            _asignacionServiceRepo = clienteService;
        }
        public bool asignarCliente(AsignacionClienteModel cliente)
        {
            _asignacionServiceRepo.asignarCliente(cliente);
            return true;
            
        }
    }
}
