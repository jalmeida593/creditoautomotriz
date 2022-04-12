using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Impl
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public VehiculoRepository(CreditoAutomotrizDBContext creditoAutomotriz)
        {
            this._creditoAutomotriz = creditoAutomotriz;
        }
        public bool Delete(int id)
        {
            var entity = GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            _creditoAutomotriz.Remove(entity);
            _creditoAutomotriz.SaveChanges();
            return true;
        }

        public List<VehiculoCreateModel> GetAll()
        {
            return _creditoAutomotriz.Set<VehiculoCreateModel>().ToList();
        }

        public VehiculoCreateModel GetById(int id)
        {
            return _creditoAutomotriz.Set<VehiculoCreateModel>().Find(id);
        }
        public VehiculoCreateModel GetByPlaca(string placa)
        {
            return _creditoAutomotriz.autos.Where(x => x.placa == placa).FirstOrDefault();
        }

        public VehiculoCreateModel Insert(VehiculoCreateModel entity)
        {
            try
            {
                var patio = GetByPlaca(entity.placa);
                if (patio == null)
                {
                    patio = entity;
                    _creditoAutomotriz.Add(patio);
                    _creditoAutomotriz.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Vehiculo ya ingresado");
                }
            }
            catch (Exception ex)
            {

            }
            return entity;
        }

        public bool Update(VehiculoCreateModel entity)
        {
            try
            {
                var patio = _creditoAutomotriz.autos.Where(x => x.idAuto == entity.idAuto).FirstOrDefault();
                if (patio != null)
                {
                    patio = entity;
                    _creditoAutomotriz.Update(patio);
                    _creditoAutomotriz.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
