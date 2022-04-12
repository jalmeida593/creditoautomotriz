using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Domain.Services.Util;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class marcasService : ImarcasService
    {
        private readonly IMarcaRepository _repo;
        public marcasService(IMarcaRepository repo)
        {
            _repo = repo;

        }
        public bool guardarData(List<MarcaModel> lista)
        {
            _repo.InsertList(lista);
            return true;
        }

        public List<MarcaModel> igualarData(List<MarcasEntity> marcasin)
        {
            List<MarcaModel> marcas = new List<MarcaModel>();
            marcasin.ForEach(data =>
            {
                MarcaModel marca = new MarcaModel();
                try
                {
                    marca.idMarca = data.idMarca;
                    marca.descripcion = data.descripcion;
                    marca.estado = int.Parse(data.estado);
                    
                }
                catch (Exception ex)
                {
                    throw new SyntaxErrorException();
                }
                marcas.Add(marca);
            });
            return marcas;
        }

        public List<MarcasEntity> leerData(string rootFolder)
        {
            ConvertCsvToDataTable conver = new ConvertCsvToDataTable();
            var lm = Util.ConvertCsvToDataTable.TransformarDataMarca(rootFolder);
            return lm;
        }
    }
}
