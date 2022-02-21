
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Controllers
{
    [Authorize]
    public class DoctorController : Controller
    {
        DoctorManager dm = new DoctorManager(new EfDoctorRepository());
        ClinicManager cm = new ClinicManager(new EfClinicRepository());
        
        public IActionResult Index()
        {
            var values = dm.GetList();
            return View(values);
        }
        public IActionResult Add()
        {
            List<SelectListItem> clinics = new List<SelectListItem>();            
            foreach (var item in cm.GetList())
            {  
                clinics.Add(new SelectListItem { Text = item.ClinicName, Value = item.ClinicId.ToString()});
            }            
            ViewBag.Clinic = clinics;
            return View();
            
        }
        [HttpPost]
        public IActionResult Add(Doctor doctor)
        {
            dm.TAdd(doctor);
            return View();            
        }
        public IActionResult Update(int id)
        {
            var updating = dm.GetById(id);
            return View(updating);
        }
        [HttpPost]
        public IActionResult Update(Doctor doctor)
        {
            dm.TUpdate(doctor);
            return RedirectToAction("Index");
        }        
        public IActionResult Delete(int id)
        {
            var value = dm.GetById(id);
            dm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
