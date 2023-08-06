using Microsoft.AspNetCore.Identity;
using YusaTosun.AspNetCoreIdentityApp.Web.Models;

namespace YusaTosun.AspNetCoreIdentityApp.Web.CustomValidations
{
    public class PasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string? password)
        {
            var errors = new List<IdentityError>();
            if (password!.ToLower().Contains(user.UserName!.ToLower()))
            {
                errors.Add(new IdentityError()
                {
                    Code = "PasswordContainUserName",Description = "Şifre kullanıcı adını içeremez",
                });
            }

            if (password.ToLower().StartsWith("1234"))
            {
                errors.Add(new IdentityError()
                {
                    Code = "PasswordStartWith1234",
                    Description = "Şifre 1234 ile başlayamaz"
                }); ;
            }
            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
