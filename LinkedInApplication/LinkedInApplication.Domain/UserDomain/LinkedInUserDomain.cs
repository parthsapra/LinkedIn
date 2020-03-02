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
        public LinkedInUserDomain(IUserUow uow, IPasswordHash passwordHash)
        {
            this.Uow = uow;
            PasswordHash = passwordHash;
        }

        public async Task<object> GetAsync(LinkedInUserAuth entity)
        {

            //return await PasswordHash.Encrypt(entity.LIPassword);
            return await Uow.Repository<LinkedInUser>().AllAsync();
        }

        public async Task<object> GetBy(LinkedInUserAuth entity)
        {
            var user = await Uow.Repository<LinkedInUser>().SingleOrDefaultAsync(t => t.LIEmailId == entity.LIEmailId);
            if (user != null && PasswordHash.VerifySignature(entity.LIPassword, user.LIPassword, user.LISalt))
            {
                return await Task.FromResult("success");
            }
            else
            {
                return await Task.FromResult("Please Enter Valid Credentials");
            }
        }
        public HashSet<string> AddValidation(LinkedInUserAuth entity)
        {
            return ValidationMessages;
        }

        private IPasswordHash PasswordHash { get; set; }

        public async Task AddAsync(LinkedInUserAuth entity)
        {
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.LIPassword);
            LinkedInUser linkedInUser = new LinkedInUser();
            linkedInUser.LIPassword = passwordResult.Signature;
            linkedInUser.LISalt = passwordResult.Salt;
            linkedInUser.LIFirstName = entity.LIFirstName;
            linkedInUser.LILastName = entity.LILastName;
            linkedInUser.LIRegistrationDate = entity.LIRegistrationDate;
            linkedInUser.IsActive = entity.IsActive;
            linkedInUser.LIMobileNumber = entity.LIMobileNumber;
            linkedInUser.LIEmailId = entity.LIEmailId;

            await Uow.RegisterNewAsync(linkedInUser);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(LinkedInUserAuth entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(LinkedInUserAuth entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(LinkedInUserAuth entity)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(LinkedInUserAuth entity)
        {
            LinkedInUser linkedInUser = new LinkedInUser();
            var userid = Uow.Repository<LinkedInUser>().FindByKey(linkedInUser.LIUserId);
            await Uow.RegisterDeletedAsync(userid);
            await Uow.CommitAsync();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ILinkedInUserDomain : ICoreDomain<LinkedInUserAuth, LinkedInUserAuth> { }
}
