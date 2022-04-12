using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Infraestructure.Data;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Impl
{
    public class AsignacionClientesRepository: IAsignacionClientesRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public AsignacionClientesRepository(CreditoAutomotrizDBContext creditoAutomotriz)
        {
            this._creditoAutomotriz = creditoAutomotriz;
        }

        public bool asignarCliente(AsignacionClienteModel cliente)
        {
            try
            {
                var patio_cliente = _creditoAutomotriz.patio_cliente.Where(x => x.idPatioCliente == cliente.idPatioCliente).FirstOrDefault();
                patio_cliente = cliente;
                _creditoAutomotriz.Add(patio_cliente);
                _creditoAutomotriz.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
