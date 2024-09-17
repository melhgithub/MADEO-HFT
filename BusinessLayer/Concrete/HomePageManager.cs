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
    public class HomePageManager : HomePageService
    {
        HomePageDal _homepageDal;
        public HomePageManager(HomePageDal homePageDal)
        {
            _homepageDal = homePageDal;
        }
        public async Task Add(HomePage t)
        {
            await _homepageDal.Insert(t);
        }

        public async Task Delete(HomePage t)
        {
            await _homepageDal.Delete(t);
        }

        public Task<HomePage> GetByID(int ID)
        {
            return _homepageDal.GetByID(ID);
        }

        public Task<List<HomePage>> GetList()
        {
            return _homepageDal.GetList();
        }

        public async Task Update(HomePage t)
        {
            await _homepageDal.Update(t);
        }
    }
}
