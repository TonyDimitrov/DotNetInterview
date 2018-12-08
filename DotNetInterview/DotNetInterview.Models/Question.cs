
using DotNetInterview.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Models
{
   public class Question : BaseEntity<string>
    {
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

        public string TaskId { get; set; }

        public string InterviewId { get; set; }

        public Interview Interview { get; set; }

        public ICollection<Rank> Ranks { get; set; } = new HashSet<Rank>();
 
    }
}
