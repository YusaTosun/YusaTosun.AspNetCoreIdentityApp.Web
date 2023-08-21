using System.ComponentModel.DataAnnotations;

namespace YusaTosun.AspNetCoreIdentityApp.Web.ViewModels
{
    public class ForgetPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "E-mail formatı yanlış")]
        [Required(ErrorMessage = "E-mail Boş Bırakılamaz")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

    }
}
