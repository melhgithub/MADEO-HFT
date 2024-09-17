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
    public class LinkManager : LinkService
    {
        LinkDal _linkDal;
        public LinkManager(LinkDal linkDal)
        {
            _linkDal = linkDal;
        }

        public async Task Add(Link t)
        {
            await _linkDal.Insert(t);
        }

        public async Task Delete(Link t)
        {
            await _linkDal.Delete(t);
        }

        public Task<Link> GetByID(int ID)
        {
            return _linkDal.GetByID(ID);
        }

        public Task<List<Link>> GetList()
        {
            return _linkDal.GetList();
        }

        public async Task Update(Link t)
        {
            await _linkDal.Update(t);
        }
    }
}
