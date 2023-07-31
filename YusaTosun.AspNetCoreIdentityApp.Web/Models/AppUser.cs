using Microsoft.AspNetCore.Identity;

namespace YusaTosun.AspNetCoreIdentityApp.Web.Models
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; } = "Istanbul";
    }
}
