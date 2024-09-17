using EntityLayer.Concrete;

namespace MADEO_HFT.Models
{
    public class BuyNowViewModel
    {
        public List<Buynow> BuyNow { get; set; }
        public List<Image> Images { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Link> Links { get; set; }
        public List<Product> Products { get; set; }
    }
}
