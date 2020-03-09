using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserCertificationDomain : IUserCertificationDomain
    {
        public UserCertificationDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(UserCertification parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(UserCertification parameters)
        {
            return await Uow.Repository<UserCertification>().FindByAsync(t => (t.UserId == parameters.UserId || t.UserCertificationId==parameters.UserCertificationId));

            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(UserCertification entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserCertification entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserCertification entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserCertification entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserCertification parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserCertification parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserCertificationDomain : ICoreDomain<UserCertification, UserCertification> { }
}
