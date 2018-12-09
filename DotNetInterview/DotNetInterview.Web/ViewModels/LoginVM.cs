using System.ComponentModel.DataAnnotations;

namespace DotNetInterview.Web.ViewModels
{
    public class LoginVM
    {
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
