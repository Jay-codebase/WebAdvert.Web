
using System.ComponentModel.DataAnnotations;


namespace WebAdvert.Web.Models.Accounts
{
    public class SignUpModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage ="Password Should be six character in length!!")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password do not match with password!!")]
        public string ConfirmPassword { get; set; }
    }
}
