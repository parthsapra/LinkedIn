using RxWeb.Core.Data;
using LinkedInApplication.BoundedContext.Main;

namespace LinkedInApplication.UnitOfWork.Main
{
    public class LookupUow : BaseUow, ILookupUow
    {
        public LookupUow(ILookupContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ILookupUow : ICoreUnitOfWork { }
}


