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
    public class PatioRepository : IPatioRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public PatioRepository(CreditoAutomotrizDBContext creditoAutomotriz)
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

        public List<PatioCreateModel> GetAll()
        {
            return _creditoAutomotriz.Set<PatioCreateModel>().ToList();
        }

        public PatioCreateModel GetById(int id)
        {
            return _creditoAutomotriz.Set<PatioCreateModel>().Find(id);
        }

        public PatioCreateModel Insert(PatioCreateModel entity)
        {
            try
            {
                var patio = _creditoAutomotriz.patioAutos.Where(x => x.idPatio == entity.idPatio).FirstOrDefault();
                patio = entity;
                _creditoAutomotriz.Add(patio);
                _creditoAutomotriz.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return entity;
        }
        public bool Update(PatioCreateModel entity)
        {
            try
            {
                var patio = _creditoAutomotriz.patioAutos.Where(x => x.idPatio == entity.idPatio).FirstOrDefault();
                if (patio != null)
                {
                    patio = entity;
                    _creditoAutomotriz.Update(patio);
                    _creditoAutomotriz.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
            return true;

        }
    }
}
