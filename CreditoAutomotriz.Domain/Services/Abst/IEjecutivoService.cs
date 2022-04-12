using CreditoAutomotriz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface IEjecutivoService
    {
        List<EjecutivosEntity> leerData(string rootFolder);
        bool guardarData(List<EjecutivosEntity> lista);
    }
}
