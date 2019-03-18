using DotNetInterview.Models.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Web.ViewModels
{
    public class CreateInterviewVM
    {
        [Display(Name = "Select Seniority")]
        public Seniority Seniority { get; set; }

        [Required]
        [MaxLength(PositionTitleMaxLength)]
        [MinLength(PositionTitleMinLength)]
        [Display(Name = "Position title")]
        public string PositionTitle { get; set; }

        [Required]
        [MaxLength(CmpNationalityMaxLength)]
        [MinLength(CmpNationalityMinLength)]
        [Display(Name = "Company nationality")]
        public string CompanyNationality { get; set; }

        [MaxLength(InterviewLocationMaxLength)]
        [MinLength(InterviewLocationMinLength)]
        [Display(Name = "Interview Location")]
        public string InterviewLocation { get; set; }

        [Required]
        [Range(CmpEmployeesMinLength, CmpEmployeesMaxLength)]
        [Display(Name = "Number of employees")]
        public int NumberOfEmployes { get; set; }

        [Range(InterviewMinTimeLength, InterviewMaxTimeLength)]
        [Display(Name = "Interview duration")]
        public float InteviewLenght { get; set; }

        public DateTime RecordDate { get; set; }

        [Display(Name = "Homework assignment")]
        public IFormFile File { get; set; }

        public IList<CreateQuestionVM> Questions { get; set; }
    }
}
