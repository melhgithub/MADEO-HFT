using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public interface SameTechnologyDatas
    {
        int ID { get; set; }
        string Title { get; set; }
        string Text1 { get; set; }
        string Text2 { get; set; }
        string Text3 { get; set; }
        string Text4 { get; set; }
        string? Image1 { get; set; }
        string? Image2 { get; set; }
        string? Banner1 { get; set; }
        string? Banner2 { get; set; }
        string? Banner3 { get; set; }
    }

}
