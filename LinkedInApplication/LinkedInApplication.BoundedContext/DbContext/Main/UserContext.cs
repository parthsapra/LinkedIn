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
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserCertification> UserCertifications { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserExperienceDetail> UserExperienceDetails { get; set; }
        public DbSet<UserEducationDetail> UserEducationDetails { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        #endregion DbSets

    }


    public interface IUserContext : IDbContext
    {
    }
}

