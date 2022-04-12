using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Infraestructure.Data;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Impl
{
    public class EmpleadoRepository:IEmpleadoRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public EmpleadoRepository(CreditoAutomotrizDBContext creditoAutomotriz)
        {
            this._creditoAutomotriz = creditoAutomotriz;
        }
        public bool InsertList(List<EjecutivosEntity> entity)
        {
            try
            {
                entity.ForEach(data =>
                {
                    var existe = GetByIdentificacion(data.identificacion);
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
        public EjecutivosEntity GetByIdentificacion(string identificacion)
        {
            return _creditoAutomotriz.empleados.Where(x => x.identificacion == identificacion).FirstOrDefault();
        }
    }
}
