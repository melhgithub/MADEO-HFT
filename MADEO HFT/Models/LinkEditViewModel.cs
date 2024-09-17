using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class LinkEditViewModel
    {
        public LinkEditDto Dto { get; set; }
        public List<Link> Link { get; set; }
    }
}
