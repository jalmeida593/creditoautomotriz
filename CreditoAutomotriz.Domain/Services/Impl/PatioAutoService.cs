using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Repository.Repository.Abst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class PatioAutoService : IPatioAutoService
    {
        private readonly IPatioRepository _repo;
        public PatioAutoService(IPatioRepository repo)
        {
            _repo = repo;

        }
        public bool actualizarPatio(PatioCreateModel Patio)
        {
            var resp = _repo.Update(Patio);
            return true;
        }

        public PatioCreateModel buscarPatio(int idPatio)
        {
            var Patio = _repo.GetById(idPatio);
            return Patio;
        }
        public bool eliminarPatio(int idPatio)
        {
            _repo.Delete(idPatio);
            return true;
        }

        public PatioCreateModel Insert(PatioCreateModel entity)
        {
            var resp = _repo.Insert(entity);
            return resp;
        }

        PatioCreateModel IPatioAutoService.buscarPatio(int idPatio)
        {
            var resp = _repo.GetById(idPatio);
            return resp;
        }

        List<PatioCreateModel> IPatioAutoService.buscarPatios()
        {
            var resp = _repo.GetAll();
            return resp;
        }
    }
}
