using Microsoft.AspNetCore.Identity;
using YusaTosun.AspNetCoreIdentityApp.Web.Models;

namespace YusaTosun.AspNetCoreIdentityApp.Web.CustomValidations
{
    public class UserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var errors = new List<IdentityError>();

            var isDigit = int.TryParse(user.UserName[0].ToString(), out _);
            if (isDigit)
            {
                errors.Add(new IdentityError()
                {
                    Code="UserNameContainFirstLetterDigit",Description="Kullanıcı adının ilk karakteri sayısal olamaz"
                });
            }

            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
