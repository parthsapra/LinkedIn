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
    public class CompanyContext : BaseBoundedContext, ICompanyContext
    {
        public CompanyContext(MainSqlDbContext sqlDbContext, IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor, ITenantDbConnectionInfo tenantDbConnection) : base(sqlDbContext, databaseConfig.Value, contextAccessor, tenantDbConnection) { }

        #region DbSets
        public DbSet<Company> Company { get; set; }
        public DbSet<vCompanyDetail> vCompanyDetail { get; set; }
        public DbSet<Headquarters> Headquarter { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Document> Documents { get; set; }
        #endregion DbSets


    }


    public interface ICompanyContext : IDbContext
    {
    }
}

