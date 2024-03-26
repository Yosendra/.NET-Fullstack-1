using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
