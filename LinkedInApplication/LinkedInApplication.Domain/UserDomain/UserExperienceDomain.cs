using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserExperienceDomain : IUserExperienceDomain
    {
        public UserExperienceDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(UserExperienceDetail parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(UserExperienceDetail parameters)
        {
            return await Uow.Repository<UserExperienceDetail>().FindByAsync(t => (t.UserId == parameters.UserId || t.UserExperienceDetailId== parameters.UserExperienceDetailId));
            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(UserExperienceDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserExperienceDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserExperienceDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserExperienceDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserExperienceDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserExperienceDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserExperienceDomain : ICoreDomain<UserExperienceDetail, UserExperienceDetail> { }
}
