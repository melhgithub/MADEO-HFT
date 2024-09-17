using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class AdminControlViewModel
    {
        public List<Admin> Admins { get; set; }
        public AdminEditDto FilterDto { get; set; }
    }
}
