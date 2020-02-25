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
	
	public class StateLookupsController : BaseLookupController

    {
        public StateLookupsController(IMasterUow uow):base(uow) {}

        #region Lookups
        		[HttpGet("State")]
		public IQueryable<vState> GetState()
		{
			return Uow.Repository<vState>().Queryable();
		}
            #endregion Lookups

    }
}
