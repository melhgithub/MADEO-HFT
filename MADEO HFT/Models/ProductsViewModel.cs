using MADEO_HFT.DataTransferObjects;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace MADEO_HFT.Models
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }
        public ProductFilterDto FilterDto { get; set; }
    }
}
