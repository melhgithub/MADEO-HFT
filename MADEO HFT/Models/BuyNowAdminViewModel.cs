using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class BuyNowAdminViewModel
    {
        public BuyNowEditDto FilterDto { get; set; }
        public List<Buynow> Buynow { get; set; }
        public List<Image> Images { get; set; }
        public List<Link> Links { get; set; }
    }
}
