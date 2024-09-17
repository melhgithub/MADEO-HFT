using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string? Slider1 { get; set; }
        public string? Slider2 { get; set; }
        public string? Slider3 { get; set; }
        public string? Slider4 { get; set; }
        public string? Slider5 { get; set; }




        public bool Video1 { get; set; }
        public string? Video1Link { get; set; }
        public string? Video1Title { get; set; }
        public string? Video1Text { get; set; }
        public bool Video2 { get; set; }
        public string? Video2Link { get; set; }
        public string? Video2Title { get; set; }
        public string? Video2Text { get; set; }
        public bool Video3 { get; set; }
        public string? Video3Link { get; set; }
        public string? Video3Title { get; set; }
        public string? Video3Text { get; set; }
        public bool Video4 { get; set; }
        public string? Video4Link { get; set; }
        public string? Video4Title { get; set; }
        public string? Video4Text { get; set; }
        public bool Video5 { get; set; }
        public string? Video5Link { get; set; }
        public string? Video5Title { get; set; }
        public string? Video5Text { get; set; }
    }
}
