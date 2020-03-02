using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.Domain.UserModule;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using System.Threading.Tasks;
using LinkedInApplication.UnitOfWork.Main;
using RxWeb.Core;
using LinkedInApplication.Models.ViewModels;

namespace LinkedInApplication.Api.Controllers.UserModule
{
    [ApiController]
    [Route("api/[controller]")]

    public class LinkedInUsersController : BaseDomainController<LinkedInUserAuth, LinkedInUserAuth>
    {
        public LinkedInUsersController(ILinkedInUserDomain domain) : base(domain)
        { }
        
        
    }

}

