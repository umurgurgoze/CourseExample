using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.ViewComponents
{
    public class SelectDoctorViewComponent : ViewComponent
    {
        DoctorManager dm = new DoctorManager(new EfDoctorRepository());
        public IViewComponentResult Invoke()
        {
            var degisken = dm.GetList();
            return View(degisken);
        }
    }
}
