
using DotNetInterview.Web.ViewModels;
using System.Collections.Generic;

namespace DotNetInterview.Web.Services.Interfaces
{
   public interface IInterviewService
    {
        CreateInterviewVM SetSeniority(string position);
    }
}

