using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.Domain.CompanyModule;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LinkedInApplication.Api.Controllers.CompanyModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class CompanyDetailController : BaseDomainController<vCompanyDetail, vCompanyDetail>

    {
        public CompanyDetailController(ICompanyDetailDomain domain):base(domain) {}

    }
}
