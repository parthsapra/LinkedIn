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
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class UserExperienceController : BaseDomainController<UserExperienceDetail, UserExperienceDetail>

    {
        public UserExperienceController(IUserExperienceDomain domain):base(domain) {}

    }
}
