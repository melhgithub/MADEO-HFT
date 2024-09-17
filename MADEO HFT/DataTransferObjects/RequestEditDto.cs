using System.ComponentModel.DataAnnotations;

namespace MADEO_HFT.DataTransferObjects
{
    public class RequestEditDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}
