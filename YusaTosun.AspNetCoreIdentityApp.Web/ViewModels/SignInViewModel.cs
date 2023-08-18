using System.ComponentModel.DataAnnotations;

namespace YusaTosun.AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignInViewModel
    {
        [EmailAddress(ErrorMessage = "E-mail formatı yanlış")]
        [Required(ErrorMessage = "E-mail Boş Bırakılamaz")]
        [Display(Name = "Email :")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }
        [Display(Name ="Beni Hatırla")]
        public bool RememberMe { get; set; }
        public SignInViewModel(string password, string email)
        {
            Password = password;
            Email = email;
        }
        public SignInViewModel()
        {
        }
    }
}
