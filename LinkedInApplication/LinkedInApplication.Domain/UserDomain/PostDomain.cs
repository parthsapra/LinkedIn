using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;

namespace LinkedInApplication.Domain.UserModule
{
    public class PostDomain : IPostDomain
    {
        public PostDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Post parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(Post parameters)
        {
            return await Uow.Repository<Post>().FindByAsync(t => (t.UserId == parameters.UserId || t.PostId==parameters.PostId));
            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Post entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Post entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Post parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Post parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostDomain : ICoreDomain<Post, Post> { }
}
