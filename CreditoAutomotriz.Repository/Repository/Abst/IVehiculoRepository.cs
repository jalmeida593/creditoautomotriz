using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository
{
    public interface IVehiculoRepository
    {
        List<VehiculoCreateModel> GetAll();
        VehiculoCreateModel GetById(int id);
        VehiculoCreateModel Insert(VehiculoCreateModel entity);
        bool Update(VehiculoCreateModel entity);
        bool Delete(int id);
    }
}
