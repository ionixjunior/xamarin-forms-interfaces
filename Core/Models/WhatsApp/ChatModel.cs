using System;

namespace Core.Models.WhatsApp
{
    public class ChatModel
    {
        public string Photo { get; set; }
        public string SentFrom { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Message { get; set; }
        public string MessageIcon { get; set; }
        public bool IsMuted { get; set; }
        public int TotalUnread { get; set; }
    }
}
