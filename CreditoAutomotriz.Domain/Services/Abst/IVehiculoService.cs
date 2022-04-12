using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface IVehiculoService
    {
        VehiculoCreateModel crearVehiculo(VehiculoCreateModel Vehiculo);
        bool actualizarVehiculo(VehiculoCreateModel Vehiculo);
        VehiculoCreateModel buscarVehiculo(int idVehiculo);
        List<VehiculoCreateModel> buscarVehiculos();
        bool eliminarVehiculo(int idVehiculo);
    }
}
