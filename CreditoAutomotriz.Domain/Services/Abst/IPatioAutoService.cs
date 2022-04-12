using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface IPatioAutoService
    {
        PatioCreateModel Insert(PatioCreateModel entity);
        bool actualizarPatio(PatioCreateModel Patio);
        PatioCreateModel buscarPatio(int idPatio);
        List<PatioCreateModel> buscarPatios();
        bool eliminarPatio(int idPatio);
    }
}
