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
	
	public class CountryLookupsController : BaseLookupController

    {
        public CountryLookupsController(IMasterUow uow):base(uow) {}

        #region Lookups
        		[HttpGet("Country")]
		public IQueryable<vCountry> GetCountry()
		{
			return Uow.Repository<vCountry>().Queryable();
		}
            #endregion Lookups

    }
}
