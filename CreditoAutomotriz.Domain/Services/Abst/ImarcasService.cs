using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface ImarcasService
    {
        List<MarcasEntity> leerData(string rootFolder);
        List<MarcaModel> igualarData(List<MarcasEntity> marcas);
        bool guardarData(List<MarcaModel> lista);
    }
}
