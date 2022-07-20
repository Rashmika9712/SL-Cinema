using System.ComponentModel.DataAnnotations;

namespace SLCinema.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name ="Email address")]
        [Required(ErrorMessage ="Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm password is required")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
