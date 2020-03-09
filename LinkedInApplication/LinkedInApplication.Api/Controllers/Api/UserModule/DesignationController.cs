using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.Domain.UserModule;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LinkedInApplication.Api.Controllers.UserModule
{
    [ApiController]
    [Route("api/linkedinusers/{LIUserId}/[controller]")]
    [AllowAnonymous]
    public class DesignationController : BaseDomainController<Designation, Designation>

    {
        public DesignationController(IDesignationDomain domain):base(domain) {}

    }
}
