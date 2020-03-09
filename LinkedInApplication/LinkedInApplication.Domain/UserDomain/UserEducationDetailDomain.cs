using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserEducationDetailDomain : IUserEducationDetailDomain
    {
        public UserEducationDetailDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(UserEducationDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(UserEducationDetail parameters)
        {
            return await Uow.Repository<UserEducationDetail>().FindByAsync(t => (t.UserId == parameters.UserId || t.UserEducationDetailId==parameters.UserEducationDetailId));
            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(UserEducationDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserEducationDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserEducationDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserEducationDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserEducationDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserEducationDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserEducationDetailDomain : ICoreDomain<UserEducationDetail, UserEducationDetail> { }
}
