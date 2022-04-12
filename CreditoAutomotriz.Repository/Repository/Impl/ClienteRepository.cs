using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using CreditoAutomotriz.Infraestructure.Data;
using CreditoAutomotriz.Repository.Repository.Abst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CreditoAutomotriz.Repository.Repository.Impl
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CreditoAutomotrizDBContext _creditoAutomotriz;

        public ClienteRepository(CreditoAutomotrizDBContext creditoAutomotriz)
        {
            this._creditoAutomotriz = creditoAutomotriz;
        }

        public async Task Delete(int id)
        {
            var entity = GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            _creditoAutomotriz.Remove(entity);
            _creditoAutomotriz.SaveChanges();
        }

        public List<UserCreateModel> GetAll()
        {
            return _creditoAutomotriz.Set<UserCreateModel>().ToList();
        }

        public UserCreateModel GetById(int id)
        {
            return _creditoAutomotriz.Set<UserCreateModel>().Find(id);
        }
        public UserCreateModel GetByIdentificacion(string identificacion)
        {
            return _creditoAutomotriz.clientes.Where(x => x.identificacion == identificacion).FirstOrDefault();
        }

        public async Task<UserCreateModel> Insert(UserCreateModel entity)
        {
            try
            {
                var cuentacliente = _creditoAutomotriz.clientes.Where(x => x.idCliente == entity.idCliente).FirstOrDefault();
                if (cuentacliente != null)
                {
                    cuentacliente = entity;
                    _creditoAutomotriz.Add(cuentacliente);
                    _creditoAutomotriz.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
            return entity;
        }
        public bool InsertList(List<UserCreateModel> entity)
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

        public async Task<UserCreateModel> Update(UserCreateModel entity)
        {
            try
            {
                var cuentacliente = _creditoAutomotriz.clientes.Where(x => x.idCliente == entity.idCliente).FirstOrDefault();
                if (cuentacliente != null)
                {
                    cuentacliente = entity;
                    _creditoAutomotriz.Update(cuentacliente);
                    _creditoAutomotriz.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
            return entity;
        }
    }
}
