
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
    public class DoctorController : Controller
    {
        DoctorManager dm = new DoctorManager(new EfDoctorRepository());
        [Authorize]
        public IActionResult Index()
        {
            var values = dm.GetList();
            return View(values);
        }
    }
}
