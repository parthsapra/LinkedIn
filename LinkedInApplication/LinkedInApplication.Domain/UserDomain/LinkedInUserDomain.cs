using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.Security.Cryptography;
using LinkedInApplication.Models.ViewModels;

namespace LinkedInApplication.Domain.UserModule
{
    public class LinkedInUserDomain : ILinkedInUserDomain
    {
        public LinkedInUserDomain(IUserUow uow, IPasswordHash passwordHash) {
            this.Uow = uow;
            PasswordHash = passwordHash;
        }

        public async Task<object> GetAsync(LInkedInUserAuth parameters)
        {
            return await Uow.Repository<LinkedInUser>().AllAsync();
           // throw new NotImplementedException();
        }

        public async Task<object> GetBy(LInkedInUserAuth parameters)
        {
            var user = await Uow.Repository<LinkedInUser>().FirstOrDefaultAsync(t => (t.LIEmailId == parameters.LIEmailId) || (t.LIMobileNumber==parameters.LIMobileNumber));
            if (user != null && PasswordHash.VerifySignature(parameters.Password,user.Password,user.Salt))
            {
                 return await Task.FromResult(user); 
            }
            else
            {
                return await Task.FromResult(0);
            }
            //throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(LInkedInUserAuth entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(LInkedInUserAuth entity)
        {
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.Password);
            LinkedInUser linkedInUser = new LinkedInUser();
            linkedInUser.Password = passwordResult.Signature;
            linkedInUser.Salt = passwordResult.Salt;
            linkedInUser.LIFirstName = entity.LIFirstName;
            linkedInUser.LILastName = entity.LILastName;
            linkedInUser.LIRegistrationDate = entity.LIRegistrationDate;
            linkedInUser.IsActive = entity.IsActive;
            linkedInUser.LIMobileNumber = entity.LIMobileNumber;
            linkedInUser.LIEmailId = entity.LIEmailId;
            await Uow.RegisterNewAsync(linkedInUser);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(LInkedInUserAuth entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(LInkedInUserAuth entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(LInkedInUserAuth parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(LInkedInUserAuth parameters)
        {
            //var LinkedInUser = Uow.Repository<LinkedInUser>().FindByAsync(t=> t.LIUserId==parameters.LIUserId);
            await Uow.RegisterDeletedAsync(parameters);
            await Uow.CommitAsync();
            //throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IPasswordHash PasswordHash { get; set; }

    }

    public interface ILinkedInUserDomain : ICoreDomain<LInkedInUserAuth, LInkedInUserAuth> { }
}
