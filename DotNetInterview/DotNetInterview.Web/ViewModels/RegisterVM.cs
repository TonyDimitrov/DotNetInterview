
using System;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Web.ViewModels
{
    public class RegisterVM : LoginVM
    {
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Forname { get; set; }

        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Surname { get; set; }

        [MaxLength(NationalityMaxLength)]
        [MinLength(NationalityMinLength)]
        public string Nationality { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime Dob { get; set; }

        [Range(ExperienceMinValue, ExperienceMaxValue)]
        [Display(Name = "Years of experience")]
        public int Experience { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
