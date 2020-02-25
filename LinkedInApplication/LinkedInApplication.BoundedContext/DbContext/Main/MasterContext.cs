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
    public class MasterContext : BaseBoundedContext, IMasterContext
    {
        public MasterContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<City> City { get; set; }
		public DbSet<State> State { get; set; }
		public DbSet<Country> Country { get; set; }
            #endregion DbSets


    }


    public interface IMasterContext : IDbContext
    {
    }
}

