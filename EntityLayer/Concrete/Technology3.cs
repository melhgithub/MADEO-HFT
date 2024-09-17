using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Technology3 : SameTechnologyDatas
    {
        [Key]
        public int ID { get; set; }
        public string MainTitle { get; set; }
        public string Title { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Banner1 { get; set; }
        public string? Banner2 { get; set; }
        public string? Banner3 { get; set; }
    }
}
