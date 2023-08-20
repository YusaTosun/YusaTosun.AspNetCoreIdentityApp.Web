﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YusaTosun.AspNetCoreIdentityApp.Web.Models;

namespace YusaTosun.AspNetCoreIdentityApp.Web.Controllers
{
    public class MemberController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public MemberController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> LogOut(string returnUrl)
        {
           await _signInManager.SignOutAsync();
            return LocalRedirect(returnUrl);
        }
    }
}
