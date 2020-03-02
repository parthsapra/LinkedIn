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
	
	public class UsersController : BaseDomainController<User,User>

    {
        public UsersController(IUserDomain domain):base(domain) {}

    }
}
