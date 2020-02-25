using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LinkedInApplication.Api.Controllers.CompanyModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class CompanyController : BaseController<Company,Company,Company>

    {
        public CompanyController(ICompanyUow uow):base(uow) {}

    }
}
