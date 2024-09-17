using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class BannerAdminViewModel
    {
        public BannerEditDto FilterDto { get; set; }
        public List<Banner> Banner { get; set; }
        public List<Image> Images { get; set; }
    }
}
