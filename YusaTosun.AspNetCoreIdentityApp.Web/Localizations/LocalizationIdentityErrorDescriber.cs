using Microsoft.AspNetCore.Identity;

namespace YusaTosun.AspNetCoreIdentityApp.Web.Localizations
{
    public class LocalizationIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError() { Code = "DuplidateUserName", Description = $"{userName} başka bir kullanıcı tarafından alınmıştır" };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError() { Code = "DuplidateEmail", Description = $"{email}  başka bir kullanıcı tarafından alınmıştır" };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError() { Code = "PasswordTooShort", Description = $"Şifre en az 6 karakterli olmalı" };
        }
    }
}
