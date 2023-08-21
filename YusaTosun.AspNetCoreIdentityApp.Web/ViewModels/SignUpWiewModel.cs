using System.ComponentModel.DataAnnotations;

namespace YusaTosun.AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpWiewModel
    {
        public SignUpWiewModel()
        {

        }
        public SignUpWiewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }

        [Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılamaz")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "E-mail formatı yanlış")]
        [Required(ErrorMessage = "E-mail Boş Bırakılamaz")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası Boş Bırakılamaz")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [Display(Name = "Şifre :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Şifreleriniz aynı değil.")] //todo : Aldığı parametreleri incele
        [Required(ErrorMessage = "Şifre Tekrarı Boş Bırakılamaz")]
        [Display(Name = "Şifre Tekrar :")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }


    }
}
