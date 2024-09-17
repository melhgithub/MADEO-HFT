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

    public class FooterManager : FooterService
    {

        FooterDal _footerDal;

        public FooterManager(FooterDal footerDal)
        {
            _footerDal = footerDal;
        }
        public async Task Add(Footer t)
        {
            await _footerDal.Insert(t);
        }

        public async Task Delete(Footer t)
        {
            await _footerDal.Delete(t);
        }

        public async Task<Footer> GetByID(int ID)
        {
            return await _footerDal.GetByID(ID);
        }

        public async Task<List<Footer>> GetList()
        {
            return await _footerDal.GetList();
        }

        public async Task Update(Footer t)
        {
            await _footerDal.Update(t);
        }
    }
}
