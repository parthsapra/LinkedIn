using LinkedInApplication.BoundedContext.Main;
using RxWeb.Core.Data;

namespace LinkedInApplication.UnitOfWork.Lookups
{
    public class LocationUow : BaseUow, ILocationUow
    {

        public LocationUow(ILocationLookupContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ILocationUow : ICoreUnitOfWork { }
}


