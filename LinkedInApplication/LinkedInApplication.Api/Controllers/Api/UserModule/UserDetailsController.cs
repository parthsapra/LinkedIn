using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.Domain.UserModule;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LinkedInApplication.Api.Controllers.UserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class UserDetailsController : BaseDomainController<UserDetail,UserDetail>

    {
        public UserDetailsController(IUserDetailDomain domain):base(domain) {}

    }
}
