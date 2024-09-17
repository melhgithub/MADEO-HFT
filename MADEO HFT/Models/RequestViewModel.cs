using EntityLayer.Concrete;
using MADEO_HFT.DataTransferObjects;

namespace MADEO_HFT.Models
{
    public class RequestViewModel
    {
        public RequestEditDto FilterDto { get; set; }
        public List<Form> Requests { get; set; }
    }
}
