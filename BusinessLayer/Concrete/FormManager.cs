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
    public class FormManager : FormService
    {
        FormDal _formDal;
        public FormManager(FormDal formDal)
        {
            _formDal = formDal;
        }
        public async Task Add(Form t)
        {
            await _formDal.Insert(t);
        }

        public async Task Delete(Form t)
        {
            await _formDal.Delete(t);
        }

        public async Task<Form> GetByID(int ID)
        {
            return await _formDal.GetByID(ID);
        }

        public async Task<List<Form>> GetList()
        {
            return await _formDal.GetList();
        }

        public async Task Update(Form t)
        {
            await _formDal.Update(t);
        }
    }
}
