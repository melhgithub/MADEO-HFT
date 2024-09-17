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
    public class ProductManager : ProductService
    {
        ProductDal _productDal;
        public ProductManager(ProductDal productDal)
        {
            _productDal = productDal;            
        }
        public async Task Add(Product t)
        {
            await _productDal.Insert(t);
        }

        public async Task Delete(Product t)
        {
            await _productDal.Delete(t);
        }

        public Task<Product> GetByID(int ID)
        {
            return _productDal.GetByID(ID);
        }

        public Task<List<Product>> GetList()
        {
            return _productDal.GetList();
        }

        public async Task Update(Product t)
        {
            await _productDal.Update(t);
        }
    }
}
