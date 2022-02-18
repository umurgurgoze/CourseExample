using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    public class AppointmentController : Controller
    {

        AppointmentManager apm = new AppointmentManager(new EfAppointmentRepository());
        [Authorize]
        public IActionResult Index()
        {
            var values = apm.GetList();
            return View(values);
        }
        
    }
}
