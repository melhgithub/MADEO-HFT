using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface GenericService<T>
    {
        Task Add(T t);
        Task Delete(T t);
        Task Update(T t);
        Task<T> GetByID(int ID);
        Task<List<T>> GetList();
    }
}
