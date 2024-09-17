using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface GenericDal<T> where T : class
    {
        Task Insert(T t);
        Task Update(T t);
        Task Delete(T t);
        Task<List<T>> GetList();
        Task<T> GetByID(int ID);

        Task<Image> GetImageByName(string name);
    }
}
