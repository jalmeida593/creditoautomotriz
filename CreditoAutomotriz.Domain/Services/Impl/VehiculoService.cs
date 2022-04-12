using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository _repo;
        public VehiculoService(IVehiculoRepository repo)
        {
            _repo = repo;

        }
        public bool actualizarVehiculo(VehiculoCreateModel Vehiculo)
        {
            _repo.Update(Vehiculo);
            return true;
        }

        public VehiculoCreateModel buscarVehiculo(int idVehiculo)
        {
            var resp=_repo.GetById(idVehiculo);
            return resp;
        }

        public List<VehiculoCreateModel> buscarVehiculos()
        {
            var resp = _repo.GetAll();
            return resp;
        }

        public VehiculoCreateModel crearVehiculo(VehiculoCreateModel Vehiculo)
        {
            var resp = _repo.Insert(Vehiculo);
            return resp;
        }

        public bool eliminarVehiculo(int idVehiculo)
        {
            var resp = _repo.Delete(idVehiculo);
            return true;
        }
    }
}
