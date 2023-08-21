using System.ComponentModel.DataAnnotations;

namespace YusaTosun.AspNetCoreIdentityApp.Web.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [Display(Name = "Yeni Şifre :")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifreleriniz aynı değil.")] //todo : Aldığı parametreleri incele
        [Required(ErrorMessage = "Şifre Tekrarı Boş Bırakılamaz")]
        [Display(Name = "Yeni Şifre Tekrar :")]
        public string? PasswordConfirm { get; set; }
    }
}
