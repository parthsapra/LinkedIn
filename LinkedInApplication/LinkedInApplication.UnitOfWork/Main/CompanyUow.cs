using RxWeb.Core.Data;
using LinkedInApplication.BoundedContext.Main;

namespace LinkedInApplication.UnitOfWork.Main
{
    public class CompanyUow : BaseUow, ICompanyUow
    {
        public CompanyUow(ICompanyContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ICompanyUow : ICoreUnitOfWork { }
}


