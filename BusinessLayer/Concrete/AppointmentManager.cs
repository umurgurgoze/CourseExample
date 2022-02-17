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
    public class AppointmentManager : IGenericService<Appointment>
    {
        IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public Appointment GetById(int id)
        {
            return _appointmentDal.GetByID(id);
        }

        public List<Appointment> GetList()
        {
            return _appointmentDal.GetListAll();
        }

        public void TAdd(Appointment t)
        {
            _appointmentDal.Insert(t);
        }

        public void TDelete(Appointment t)
        {
            _appointmentDal.Delete(t);
        }

        public void TUpdate(Appointment t)
        {
            _appointmentDal.Update(t);
        }
    }
}
