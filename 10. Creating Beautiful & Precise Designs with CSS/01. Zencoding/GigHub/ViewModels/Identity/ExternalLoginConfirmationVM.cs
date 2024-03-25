using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class ExternalLoginConfirmationVM
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
