using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static DotNetInterview.Common.ModelConstants;

namespace DotNetInterview.Models
{
    public class DNIUser : IdentityUser
    {
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Forname { get; set; }

        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Surname { get; set; }

        [MaxLength(NationalityMaxLength)]
        [MinLength(NationalityMinLength)]
        public string Nationality { get; set; }

        public DateTime Dob { get; set; }

        public string AvatarId { get; set; }

        public bool IsActive { get; set; }

        [Range(ExperienceMinValue, ExperienceMaxValue)]
        public int Experience { get; set; }

        public ICollection<Interview> Interviews { get; set; } = new HashSet<Interview>();

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public ICollection<Rank> Ranks { get; set; } = new HashSet<Rank>();


    }
}
