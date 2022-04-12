using CreditoAutomotriz.Entities;
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
    public class MarcaRepository : IMarcaRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public MarcaRepository(CreditoAutomotrizDBContext creditoAutomotriz)
        {
            this._creditoAutomotriz = creditoAutomotriz;
        }

        public bool InsertList(List<MarcaModel> entity)
        {
            try
            {
                entity.ForEach(data =>
                {
                    var existe = GetByName(data.descripcion);
                    if (existe == null)
                    {
                        _creditoAutomotriz.Add(data);
                        _creditoAutomotriz.SaveChangesAsync();
                        Thread.Sleep(2000);
                    }
                });

                _creditoAutomotriz.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public MarcaModel GetByName(string desc)
        {
            return _creditoAutomotriz.marcasVehiculos.Where(x => x.descripcion.StartsWith(desc)).FirstOrDefault();
        }
    }
}
