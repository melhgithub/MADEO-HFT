using EntityLayer.Concrete;

namespace MADEO_HFT.Models
{
    public class HeaderModel
    {
        public List<Link> Links { get; set; }
        public List<Technology1> Technology1 { get; set; }
        public List<Technology2> Technology2 { get; set; }
        public List<Technology3> Technology3 { get; set; }
    }
}
