using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class HomePageAdminViewModel
    {
        public HomePageEditDto FilterDto{ get; set; }
        public List<HomePage> HomePage{ get; set; }
        public List<Image> Images{ get; set; }
    }
}
