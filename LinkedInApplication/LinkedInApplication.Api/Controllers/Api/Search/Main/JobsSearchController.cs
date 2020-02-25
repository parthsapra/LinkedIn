using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Security;
using RxWeb.Core.Data;
using LinkedInApplication.Models.ViewModels;
using LinkedInApplication.BoundedContext.SqlContext;
namespace LinkedInApplication.Api.Controllers.MasterModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchJobsController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchJobsController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "Designation", Value = searchParams["Designation"] };
            spParameters[1] = new SqlParameter() { ParameterName = "Location", Value = searchParams["Location"] };
            
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spSearchJobs",spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
