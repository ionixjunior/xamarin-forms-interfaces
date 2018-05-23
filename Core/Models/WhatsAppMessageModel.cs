using System;
namespace Core.Models
{
    public class WhatsAppMessageModel
    {
        public string Photo { get; set; }
        public string SentFrom { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Message { get; set; }
        public string MessageIcon { get; set; }
        public bool IsMuted { get; set; }
    }
}
