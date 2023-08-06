using Microsoft.Extensions.DependencyInjection;
using YusaTosun.AspNetCoreIdentityApp.Web.CustomValidations;
using YusaTosun.AspNetCoreIdentityApp.Web.Models;

namespace YusaTosun.AspNetCoreIdentityApp.Web.Extensions
{
    public static class StartupExtensions
    {
        public static void AddIdentityWithExt(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "qwertyuopasdfghjklizxcvbnm1234567890";
    
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;
            }).AddPasswordValidator<PasswordValidator>().AddEntityFrameworkStores<AppDbContext>();

        }
    }
}
