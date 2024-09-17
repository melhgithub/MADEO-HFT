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
    public class AdminManager : AdminService
    {
        AdminDal _adminDal;
        public AdminManager(AdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public async Task Add(Admin t)
        {
            await _adminDal.Insert(t);
        }

        public async Task Delete(Admin t)
        {
            await _adminDal.Delete(t);
        }

        public async Task<Admin> GetByID(int ID)
        {
            return await _adminDal.GetByID(ID);
        }

        public async Task<List<Admin>> GetList()
        {
            return await _adminDal.GetList();
        }

        public async Task Update(Admin t)
        {
            await _adminDal.Update(t);
        }
    }
}
