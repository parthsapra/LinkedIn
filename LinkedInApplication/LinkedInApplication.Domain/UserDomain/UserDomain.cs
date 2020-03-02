using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserDomain : IUserDomain
    {
        public UserDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(User entity)
        {
            //return await 
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(User entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(User entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(User entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(User entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(User entity)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserDomain : ICoreDomain<User,User> { }
}
