using CreditoAutomotriz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Abst
{
    public interface IEmpleadoRepository
    {
        bool InsertList(List<EjecutivosEntity> entity);
    }
}
