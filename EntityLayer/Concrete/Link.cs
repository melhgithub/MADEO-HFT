using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public enum LinkStatuses
    {
        [Description("TÜMÜ")]
        All = 0,

        [Description("Aktif")]
        Active = 1,

        [Description("Aktif Değil")]
        Deactive = 2,
    }
    public class Link
    {
        [Key]
        public int ID { get; set; }
        public string Linkedin { get; set; }
        public string Tiktok { get; set; }
        public string Youtube { get; set; }
        public string Telegram { get; set; }
        public string Whatsapp { get; set; }
        public string Gmail { get; set; }
        public bool LinkedinStatus { get; set; }
        public bool TiktokStatus { get; set; }
        public bool YoutubeStatus { get; set; }
        public bool TelegramStatus { get; set; }
        public bool WhatsappStatus { get; set; }
        public bool GmailStatus { get; set; }
        public LinkStatuses? GeneralStatus { get; set; }
    }
}
