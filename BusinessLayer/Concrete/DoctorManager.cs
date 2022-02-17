using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DoctorManager : IGenericService<Doctor>
    {
        IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public Doctor GetById(int id)
        {
           return _doctorDal.GetByID(id);
        }

        public List<Doctor> GetList()
        {
           return _doctorDal.GetListAll();
        }

        public void TAdd(Doctor t)
        {
            _doctorDal.Insert(t);
        }

        public void TDelete(Doctor t)
        {
            _doctorDal.Delete(t);
        }

        public void TUpdate(Doctor t)
        {
            _doctorDal.Update(t);
        }
    }
}
