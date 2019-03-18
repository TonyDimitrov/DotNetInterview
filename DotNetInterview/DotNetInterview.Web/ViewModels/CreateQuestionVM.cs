
using DotNetInterview.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Web.ViewModels
{
    public class CreateQuestionVM
    {
        [Required]
        [MaxLength(QuestionMaxLength)]
        [MinLength(QuestionMaxLength)]
        public string Content { get; set; }

        [MaxLength(AnswerMaxLength)]
        [MinLength(AnswerMinLength)]
        public string GivenAnswer { get; set; }

        [MaxLength(AnswerMaxLength)]
        [MinLength(AnswerMinLength)]
        public string Answer { get; set; }

        public Ranked Ranked { get; set; }
    }
}
