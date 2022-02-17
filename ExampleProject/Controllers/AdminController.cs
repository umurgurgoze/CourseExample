using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AdminUser user)
        {
            var bilgiler = c.AdminUsers.FirstOrDefault(x => x.AdminUserName == user.AdminUserName && x.AdminPassword == user.AdminPassword);
            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.AdminUserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Appointment");
            }
            return View();
            
            
        }
    }
}
