using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LinkedInApplication.Api.Controllers.UserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class UserDetailsController : BaseController<UserDetail,UserDetail,UserDetail>

    {
        public UserDetailsController(IUserUow uow):base(uow) {}

    }
}
