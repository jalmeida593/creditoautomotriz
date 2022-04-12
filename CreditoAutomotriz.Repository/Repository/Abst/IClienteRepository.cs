using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Repository.Repository.Abst
{
    public interface IClienteRepository
    {
        List<UserCreateModel> GetAll();
        UserCreateModel GetById(int id);
        Task<UserCreateModel> Insert(UserCreateModel entity);
        bool InsertList(List<UserCreateModel> entity);
        Task<UserCreateModel> Update(UserCreateModel entity);
        Task Delete(int id);
    }
}
