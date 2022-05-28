using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.InputModels.Users
{

    public class LoginUserInputModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters long!")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "{0} must be between {2} and {1} characters long!")]
        public string Password { get; set; }
    }
}
