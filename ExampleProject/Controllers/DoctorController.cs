using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    public class DoctorController : Controller
    {
        GenericManager<Doctor> gm = new GenericManager<Doctor>;
        public IActionResult Index()
        {
            return View();
        }
    }
}
