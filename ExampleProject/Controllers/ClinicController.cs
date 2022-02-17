using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    public class ClinicController : Controller
    {
        ClinicManager cm = new ClinicManager(new EfClinicRepository());
        [Authorize]
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
