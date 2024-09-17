using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ImageService : GenericService<Image>
    {

        Task<Image> GetImageByName(string name);
    }
}
