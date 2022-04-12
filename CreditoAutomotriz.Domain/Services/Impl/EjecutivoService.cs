using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Domain.Services.Util;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class EjecutivoService : IEjecutivoService
    {
        private readonly IEmpleadoRepository _repo;
        public EjecutivoService(IEmpleadoRepository repo)
        {
            _repo = repo;

        }
        public bool guardarData(List<EjecutivosEntity> lista)
        {
            _repo.InsertList(lista);
            return true;
        }

        public List<EjecutivosEntity> leerData(string rootFolder)
        {
            ConvertCsvToDataTable conver = new ConvertCsvToDataTable();
            var lm = Util.ConvertCsvToDataTable.TransformarDataEjecutivo(rootFolder);
            return lm;
        }
    }
}
