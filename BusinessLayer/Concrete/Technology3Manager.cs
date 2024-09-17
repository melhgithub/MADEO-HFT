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
    public class Technology3Manager : Technology3Service
    {
        Technology3Dal _technology3Dal;
        public Technology3Manager(Technology3Dal technology3Dal)
        {
            _technology3Dal = technology3Dal;
        }

        public async Task Add(Technology3 t)
        {
            await _technology3Dal.Insert(t);
        }

        public async Task Delete(Technology3 t)
        {
            await _technology3Dal.Delete(t);
        }

        public async Task<Technology3> GetByID(int ID)
        {
            return await _technology3Dal.GetByID(ID);
        }

        public async Task<List<Technology3>> GetList()
        {
            return await _technology3Dal.GetList();
        }

        public async Task Update(Technology3 t)
        {
            await _technology3Dal.Update(t);
        }
    }
}
