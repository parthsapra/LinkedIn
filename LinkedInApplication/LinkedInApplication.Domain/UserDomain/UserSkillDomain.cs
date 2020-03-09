using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class UserSkillDomain : IUserSkillDomain
    {
        public UserSkillDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(UserSkill parameters)
        {
            return await Uow.Repository<UserSkill>().FindByAsync(t => (t.UserId == parameters.UserId || t.UserSkillId== parameters.UserSkillId));
            //throw new NotImplementedException();
        }

        public async Task<object> GetBy(UserSkill parameters)
        {
            return await Uow.Repository<UserSkill>().FindByAsync(t => (t.UserId == parameters.UserId || t.UserSkillId== parameters.UserSkillId));
            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(UserSkill entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserSkill entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserSkill entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserSkill entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserSkill parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserSkill parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserSkillDomain : ICoreDomain<UserSkill, UserSkill> { }
}
