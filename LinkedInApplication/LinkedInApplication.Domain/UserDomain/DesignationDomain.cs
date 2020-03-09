using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class DesignationDomain : IDesignationDomain
    {
        public DesignationDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(Designation parameters)
        {
            return await Uow.Repository<Designation>().AllAsync();
            //throw new NotImplementedException();
        }

        public async Task<object> GetBy(Designation parameters)
        {
           return await Uow.Repository<Designation>().FindByAsync(t=>t.UserId==parameters.UserId);
            //throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Designation entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Designation entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Designation entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Designation entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Designation parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Designation parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IDesignationDomain : ICoreDomain<Designation, Designation> { }
}
