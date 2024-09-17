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
    public class Technology2Manager : Technology2Service
    {
        Technology2Dal _technology2Dal;
        public Technology2Manager(Technology2Dal technology2Dal)
        {
            _technology2Dal = technology2Dal;
        }

        public async Task Add(Technology2 t)
        {
            await _technology2Dal.Insert(t);
        }

        public async Task Delete(Technology2 t)
        {
            await _technology2Dal.Delete(t);
        }

        public async Task<Technology2> GetByID(int ID)
        {
            return await _technology2Dal.GetByID(ID);
        }

        public async Task<List<Technology2>> GetList()
        {
            return await _technology2Dal.GetList();
        }

        public async Task Update(Technology2 t)
        {
            await _technology2Dal.Update(t);
        }
    }
}
