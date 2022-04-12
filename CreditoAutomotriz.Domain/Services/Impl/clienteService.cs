using CreditoAutomotriz.Domain.Services.Abst;
using CreditoAutomotriz.Domain.Services.Util;
using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Infraestructure.Data;
using CreditoAutomotriz.Repository.Repository.Abst;
using CreditoAutomotriz.Repository.Repository.Impl;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Domain.Services.Impl
{
    public class clienteService : IclienteService
    {
        private readonly IClienteRepository _repo;
        public clienteService(IClienteRepository repo)
        {
            _repo = repo;

        }
        public bool actualizarCliente(UserCreateModel cliente)
        {
            var userEntity = _repo.Update(cliente);
            return true;
        }

        public UserCreateModel buscarCliente(int idCliente)
        {
            var userEntity = _repo.GetById(idCliente);
            return userEntity;

        }

        public List<UserCreateModel> buscarClientes()
        {
            var usersEntity = _repo.GetAll();
            return usersEntity;
        }

        public Task<UserCreateModel> crearCliente(UserCreateModel cliente)
        {
            var usersEntity = _repo.Insert(cliente);
            return usersEntity;
        }

        public bool eliminarCliente(int idCliente)
        {
            var eliminar = _repo.Delete(idCliente);
            return true;
        }

        public bool guardarData(List<clientesEntity> lista)
        {
            var lc = Util.ConvertCsvToDataTable.igualarData(lista);
            var create = _repo.InsertList(lc);
            return true;
        }

        public List<clientesEntity> leerData(string rootFolder)
        {
            var lc = Util.ConvertCsvToDataTable.leerData(rootFolder);
            
            return lc;
        }

        UserCreateModel IclienteService.buscarCliente(int idCliente)
        {
            var userEntity = _repo.GetById(idCliente);
            return userEntity;
        }
    }
}
