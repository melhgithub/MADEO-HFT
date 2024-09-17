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
    public class Technology1Manager : Technology1Service
    {
        Technology1Dal _technology1Dal;
        public Technology1Manager(Technology1Dal technology1Dal)
        {
            _technology1Dal = technology1Dal;
        }

        public async Task Add(Technology1 t)
        {
            await _technology1Dal.Insert(t);
        }

        public async Task Delete(Technology1 t)
        {
            await _technology1Dal.Delete(t);
        }

        public async Task<Technology1> GetByID(int ID)
        {
            return await _technology1Dal.GetByID(ID);
        }

        public async Task<List<Technology1>> GetList()
        {
            return await _technology1Dal.GetList();
        }

        public async Task Update(Technology1 t)
        {
            await _technology1Dal.Update(t);
        }
    }
}
