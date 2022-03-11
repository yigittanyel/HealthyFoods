using _100DerseCore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _100DerseCore.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin a)
        {
            var deger = c.Admins.FirstOrDefault(x => x.Username == a.Username && x.Password == a.Password);
            if (deger != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.Username)
                };
                var userIdentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Listele","Category");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("GirisYap", "Login");
        }

    }
}
