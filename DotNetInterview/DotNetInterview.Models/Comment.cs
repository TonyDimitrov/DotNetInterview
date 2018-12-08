
using System;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Models
{
    public class Comment : BaseEntity<string>
    {
        [MaxLength(CommentMaxLength)]
        [MinLength(CommentMinLength)]
        public string Content { get; set; }

        public DateTime CommentDate{ get; set; }

        public string UserId { get; set; }

        public  DNIUser User { get; set; }

        public string InterviewId { get; set; }

        public Interview Interview { get; set; }
    }
}
