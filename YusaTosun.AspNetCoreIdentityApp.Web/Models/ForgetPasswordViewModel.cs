using System.ComponentModel.DataAnnotations;

namespace YusaTosun.AspNetCoreIdentityApp.Web.Models
{
    public class ForgetPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "E-mail formatı yanlış")]
        [Required(ErrorMessage = "E-mail Boş Bırakılamaz")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

    }
}
