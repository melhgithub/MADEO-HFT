using EntityLayer.Concrete;

namespace MADEO_HFT.DataTransferObjects
{
    public class LinkEditDto
    {
        public int ID { get; set; }
        public string Linkedin { get; set; }
        public string Tiktok { get; set; }
        public string Youtube { get; set; }
        public string Telegram { get; set; }
        public string Whatsapp { get; set; }
        public string Gmail { get; set; }


        public string LinkedinStatus { get; set; }
        public string TiktokStatus { get; set; }
        public string YoutubeStatus { get; set; }
        public string TelegramStatus { get; set; }
        public string WhatsappStatus { get; set; }
        public string GmailStatus { get; set; }
        public string GeneralStatus { get; set; }
    }
}
