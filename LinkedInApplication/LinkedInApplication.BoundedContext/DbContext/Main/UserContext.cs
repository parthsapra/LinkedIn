using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using LinkedInApplication.BoundedContext.SqlContext;
using LinkedInApplication.Models.Main;
using LinkedInApplication.Models;
using LinkedInApplication.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace LinkedInApplication.BoundedContext.Main
{
    public class UserContext : BaseBoundedContext, IUserContext
    {
        public UserContext(MainSqlDbContext sqlDbContext, IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor, ITenantDbConnectionInfo tenantDbConnection) : base(sqlDbContext, databaseConfig.Value, contextAccessor, tenantDbConnection) { }

        #region DbSets
        public DbSet<LinkedInUser> LinkedInUser { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<UserEducationDetail> UserEducationDetail { get; set; }
        public DbSet<UserExperienceDetail> UserExperienceDetail { get; set; }
        public DbSet<UserSkill> UserSkill { get; set; }
        public DbSet<Post> Post { get; set; }
        #endregion DbSets


    }


    public interface IUserContext : IDbContext
    {
    }
}

