
using DotNetInterview.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;


namespace DotNetInterview.Models
{
   public class Interview : BaseEntity<string>
    {
        [MaxLength(CmpNationalityMaxLength)]
        [MinLength(CmpNationalityMinLength)]
        public string CompanyNationality { get; set; }

        [MaxLength(InterviewLocationMaxLength)]
        [MinLength(InterviewLocationMinLength)]
        public string InterviewLocation { get; set; }

        [Range(CmpEmployeesMinLength, CmpEmployeesMaxLength)]
        public int NumberOfEmployes { get; set; }

        public Seniority Seniority { get; set; }

        [MaxLength(PositionTitleMaxLength)]
        [MinLength(PositionTitleMinLength)]
        public string PositionTitle { get; set; }

        [Range(InterviewMinTimeLength, InterviewMaxTimeLength)]
        public float InteviewLenght { get; set; }

        public DateTime RecordDate { get; set; }

        public Difficulty Difficulty { get; set; }

        public string HomeworkTaskId { get; set; }

        public bool IsActive { get; set; }

        public string UserId { get; set; }

        public DNIUser User { get; set; }

        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
