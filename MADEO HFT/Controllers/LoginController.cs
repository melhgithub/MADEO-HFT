using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using MADEO_HFT.DataTransferObjects;
using MADEO_HFT.Models;

namespace MADEO_HFT.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EFAdminRepository());

        public async Task<IActionResult> Index()
        {
            var admins = await adminManager.GetList();

            var filter = new AdminLoginDto();

            var model = new AdminsLoginViewModel
            {
                Admins = admins,
                LoginDto = filter
            };


            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(AdminLoginDto admin)
        {
            var data = await adminManager.GetList();
            data = data.Where(x => x.UserName == admin.UserName && x.Password == admin.Password).ToList();

            if (data.Count != 0)
            {
                HttpContext.Session.SetString("username", admin.UserName);

                if (admin.UserName == "admin")
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.UserName),
                        new Claim(ClaimTypes.Role, "admin")
                    };

                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return Json(new { success = true, redirectUrl = Url.Action("Index", "Admin") });
                }
                else
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, admin.UserName),
                    };
                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return Json(new { success = true, redirectUrl = Url.Action("Index", "AdminHomePage") });
                }
            }
            else
            {
                return Json(new { success = false, message = "Geçersiz yetki ya da kullanıcı." });
            }
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}