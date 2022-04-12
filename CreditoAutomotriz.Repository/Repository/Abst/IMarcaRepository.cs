using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Abst
{
    public interface IMarcaRepository
    {
        bool InsertList(List<MarcaModel> entity);
    }
}
