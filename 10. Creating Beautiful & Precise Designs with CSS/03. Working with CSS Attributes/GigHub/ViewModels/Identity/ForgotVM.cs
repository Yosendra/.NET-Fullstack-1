using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class ForgotVM
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
