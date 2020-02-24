using Microsoft.Extensions.DependencyInjection;
using LinkedInApplication.Infrastructure.Singleton;
using LinkedInApplication.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace LinkedInApplication.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




