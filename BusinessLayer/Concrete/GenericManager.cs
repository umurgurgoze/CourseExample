using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T:class
    {
        IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public T GetById(int id)
        {
            return _genericDal.GetByID(id);
        }

        public List<T> GetList()
        {
            return _genericDal.GetListAll();
        }

        public void TAdd(T t)
        {
            _genericDal.Insert(t);
        }

        public void TDelete(T t)
        {
            _genericDal.Delete(t);
        }

        public void TUpdate(T t)
        {
            _genericDal.Update(t);
        }
    }
}
