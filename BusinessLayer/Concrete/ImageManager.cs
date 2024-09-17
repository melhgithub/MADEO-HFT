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
    public class ImageManager : ImageService
    {
        ImageDal _imageDal;
        public ImageManager(ImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public async Task Add(Image t)
        {
            await _imageDal.Insert(t);
        }

        public async Task Delete(Image t)
        {
            await _imageDal.Delete(t);
        }

        public Task<Image> GetByID(int ID)
        {
            return _imageDal.GetByID(ID);
        }

        public async Task<Image> GetImageByName(string name)
        {
            return await _imageDal.GetImageByName(name);
        }

        public Task<List<Image>> GetList()
        {
            return _imageDal.GetList();
        }

        public async Task Update(Image t)
        {
            await _imageDal.Update(t);
        }
    }
}
