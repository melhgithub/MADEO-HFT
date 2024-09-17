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
    public class BannerManager : BannerService
    {
        BannerDal _bannerDal;
        public BannerManager(BannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public async Task Add(Banner t)
        {
            await _bannerDal.Insert(t);
        }

        public async Task Delete(Banner t)
        {
            await _bannerDal.Delete(t);
        }

        public Task<Banner> GetByID(int ID)
        {
            return _bannerDal.GetByID(ID);
        }

        public Task<List<Banner>> GetList()
        {
            return _bannerDal.GetList();
        }

        public async Task Update(Banner t)
        {
            await _bannerDal.Update(t);
        }
    }
}
