using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.CompanyModule
{
    public class CompanyDetailDomain : ICompanyDetailDomain
    {
        public CompanyDetailDomain(ICompanyUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vCompanyDetail parameters)
        {
            return await Uow.Repository<vCompanyDetail>().AllAsync();
            //throw new NotImplementedException();
        }

        public async Task<object> GetBy(vCompanyDetail parameters)
        {
            return await Uow.Repository<vCompanyDetail>().FindByAsync(t => t.CompanyId == parameters.CompanyId);
            //throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vCompanyDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vCompanyDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vCompanyDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vCompanyDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vCompanyDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vCompanyDetail parameters)
        {
            throw new NotImplementedException();
        }

        public ICompanyUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ICompanyDetailDomain : ICoreDomain<vCompanyDetail, vCompanyDetail> { }
}
