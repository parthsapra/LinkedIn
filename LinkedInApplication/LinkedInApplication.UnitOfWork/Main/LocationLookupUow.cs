using RxWeb.Core.Data;
using LinkedInApplication.BoundedContext.Main;

namespace LinkedInApplication.UnitOfWork.Main
{
    public class LocationLookupUow : BaseUow, ILocationLookupUow
    {
        public LocationLookupUow(ILocationLookupContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ILocationLookupUow : ICoreUnitOfWork { }
}


