using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Buynow
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Resim1 { get; set; }
    }
}
