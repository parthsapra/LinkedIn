using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LinkedInApplication.UnitOfWork.Main;
using LinkedInApplication.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace LinkedInApplication.Api.Controllers.MasterModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class CityLookupsController : BaseLookupController

    {
        public CityLookupsController(ILookupUow uow):base(uow) {}

        #region Lookups
        		[HttpGet("City")]
		public IQueryable<vCity> GetCity()
		{
			return Uow.Repository<vCity>().Queryable();
		}
            #endregion Lookups

    }
}
