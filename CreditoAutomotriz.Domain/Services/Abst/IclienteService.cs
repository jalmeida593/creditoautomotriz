using CreditoAutomotriz.Domain.Services.Impl;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Abst
{
    public interface IclienteService
    {
        List<clientesEntity> leerData(string rootFolder);
        bool guardarData(List<clientesEntity> lista);

        Task<UserCreateModel> crearCliente(UserCreateModel cliente);
        bool actualizarCliente(UserCreateModel cliente);
        UserCreateModel buscarCliente(int idCliente);
        List<UserCreateModel> buscarClientes();
        bool eliminarCliente(int idCliente);
    }
}
