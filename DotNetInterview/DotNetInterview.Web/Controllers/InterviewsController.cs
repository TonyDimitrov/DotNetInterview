
using DotNetInterview.Data;
using DotNetInterview.Web.Services.Interfaces;
using DotNetInterview.Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace DotNetInterview.Web.Controllers
{
    public class InterviewsController : BaseController
    {
        private IInterviewService interviewService;
        private IHostingEnvironment env;

        public InterviewsController(DotNetInterviewDbContext dbContext, IInterviewService interviewService, IHostingEnvironment env)
            :base(dbContext)
        {
            this.interviewService = interviewService;
            this.env = env;
        }

        [HttpGet]
        public IActionResult Create(string position)
        {
            var model = this.interviewService.SetSeniority(position);
            return this.View( model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInterviewVM model)
         {
            var filePath = this.env.WebRootPath + "/tasks/55.jpg";

            using (var stream = new FileStream(filePath, FileMode.CreateNew))
            {
               await model.File.CopyToAsync(stream);
            }
            return this.Redirect("/");
        }
    }
}
