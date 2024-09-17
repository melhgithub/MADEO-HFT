using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class AdminsLoginViewModel
    {
        public List<Admin> Admins { get; set; }
        public AdminLoginDto LoginDto { get; set; }
    }
}
