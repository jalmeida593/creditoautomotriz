using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Abst
{
    public interface IPatioRepository
    {
        List<PatioCreateModel> GetAll();
        PatioCreateModel GetById(int id);
        PatioCreateModel Insert(PatioCreateModel entity);
        bool Update(PatioCreateModel entity);
        bool Delete(int id);
    }
}
