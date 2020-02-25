using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserDetailDomain : IUserDetailDomain
    {
        public UserDetailDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(UserDetail entity)
        {
            return await Uow.Repository<UserDetail>().AllAsync();
        }

        public async Task<object> GetBy(UserDetail entity)
        {
            return await Uow.Repository<UserDetail>().FindByAsync(t=> t.UserDetailId == entity.UserDetailId);
        }
        

        public HashSet<string> AddValidation(UserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserDetail entity)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserDetail entity)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserDetailDomain : ICoreDomain<UserDetail,UserDetail> { }
}
