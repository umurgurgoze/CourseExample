using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    public class HomeController : Controller
    {
        AppointmentManager apm = new AppointmentManager(new EfAppointmentRepository());
        DoctorManager dm = new DoctorManager(new EfDoctorRepository());

        public IActionResult Add(Appointment appointment)
        {
            apm.TAdd(appointment);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var values = dm.GetList();
            return View(values);
        }
    }
}
