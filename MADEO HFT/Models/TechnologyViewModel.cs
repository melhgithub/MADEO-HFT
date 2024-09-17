using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class TechnologyViewModel
    {
        public List<Product> Products { get; set; }
        public List<Image> Images { get; set; }
        public List<Technology1> Technology1 { get; set; }
        public List<Technology2> Technology2 { get; set; }
        public List<Technology3> Technology3 { get; set; }
        public TechnologyEditDto FilterDto { get; set; }
    }
}
