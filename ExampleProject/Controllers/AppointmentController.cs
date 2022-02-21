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
    public class AppointmentController : Controller
    {

        AppointmentManager apm = new AppointmentManager(new EfAppointmentRepository());
        [Authorize]
        public IActionResult Index()
        {
            var values = apm.GetList();
            return View(values);
        }
        public IActionResult Update(int id)
        {
            var updating = apm.GetById(id);
            return View(updating);
        }
        [HttpPost]
        public IActionResult Update(Appointment appointment)
        {
            apm.TUpdate(appointment);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var value = apm.GetById(id);
            apm.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
