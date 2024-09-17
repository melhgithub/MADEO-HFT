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
    public class BuyNowManager : BuyNowService
    {
        BuyNowDal _buynowDal;
        public BuyNowManager(BuyNowDal buynowDal)
        {
            _buynowDal = buynowDal;
        }

        public async Task Add(Buynow t)
        {
            await _buynowDal.Insert(t);
        }
        public async Task Delete(Buynow t)
        {
            await _buynowDal.Delete(t);
        }

        public Task<Buynow> GetByID(int ID)
        {
            return _buynowDal.GetByID(ID);
        }

        public Task<List<Buynow>> GetList()
        {
            return _buynowDal.GetList();
        }

        public async Task Update(Buynow t)
        {
            await _buynowDal.Update(t);
        }
    }
}
