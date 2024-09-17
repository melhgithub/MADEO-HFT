using EntityLayer.Concrete;

namespace MADEO_HFT.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public List<Product> ProductsTwo { get; set; }
        public List<Link> Links { get; set; }
        public List<Image> Images { get; set; }
        public List<Banner> Banners { get; set; }
    }
}
