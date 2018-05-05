using System;

namespace Core.Models
{
    public class WhatsAppInfoModel
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public DateTimeOffset StatusAt { get; set; }
    }
}
