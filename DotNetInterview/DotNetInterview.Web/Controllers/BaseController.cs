using DotNetInterview.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotNetInterview.Web.Controllers
{
    public class BaseController : Controller
    {

        private DotNetInterviewDbContext dbContext;

        public BaseController(DotNetInterviewDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
