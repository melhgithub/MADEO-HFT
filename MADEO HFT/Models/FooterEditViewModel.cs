using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class FooterEditViewModel
    {
        public FooterEditDto FilterDto { get; set; }
        public List<Footer> Footer { get; set; }
    }
}
