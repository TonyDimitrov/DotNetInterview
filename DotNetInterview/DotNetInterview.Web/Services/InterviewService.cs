
using System;
using System.Collections.Generic;
using System.Linq;
using DotNetInterview.Models.Enums;
using DotNetInterview.Web.Services.Interfaces;
using DotNetInterview.Web.ViewModels;

namespace DotNetInterview.Web.Services
{
    public class InterviewService : IInterviewService
    {
        public CreateInterviewVM SetSeniority(string position)
        {
            Seniority seniority;
            if (!Enum.TryParse<Seniority>(position, true, out seniority))
            {
                seniority = Seniority.Junior;
            }
            var questions = new List<CreateQuestionVM>();
            for (int i = 0; i < 5; i++)
            {
                questions.Add(new CreateQuestionVM() { Content = string.Empty });
            }
            return new CreateInterviewVM()
            {
                Questions = questions
            };
        }
    }
}
