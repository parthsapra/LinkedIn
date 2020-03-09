using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LinkedInApplication.Api.Controllers.CompanyModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class DocumentController : BaseController<Document,Document,Document>

    {
        public DocumentController(ICompanyUow uow):base(uow) {}

    }
}
