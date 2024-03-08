using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeDal
    {
        private readonly ISubscribeDal _subscribeDal;
        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }
        public void Delete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public Subscribe GetByID(int id)
        {
            return _subscribeDal.GetByID(id);
        }

        public List<Subscribe> GetList()
        {
            return _subscribeDal.GetList();
        }

        public void Insert(Subscribe entity)
        {
            _subscribeDal.Insert(entity);
        }

        public void Update(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }
    }
}
