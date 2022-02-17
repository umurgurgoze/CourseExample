using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ClinicManager : IGenericService<Clinic>
    {
        IClinicDal _clinicDal;

        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }

        public Clinic GetById(int id)
        {
           return _clinicDal.GetByID(id);
        }

        public List<Clinic> GetList()
        {
            return _clinicDal.GetListAll();
        }

        public void TAdd(Clinic t)
        {
            _clinicDal.Insert(t);
        }

        public void TDelete(Clinic t)
        {
            _clinicDal.Delete(t);
        }

        public void TUpdate(Clinic t)
        {
            _clinicDal.Update(t);
        }
    }
}
