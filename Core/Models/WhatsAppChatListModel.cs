using System;
using Core.Enums;

namespace Core.Models
{
    public class WhatsAppChatListModel
    {
        public string Photo { get; set; }
        public bool IsGroup { get; set; }
        public string GroupName { get; set; }
        public string SentFrom { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Message { get; set; }
        public bool IsMuted { get; set; }
        public bool IsRead { get; set; }
        public int TotalUnread { get; set; }
        public bool IsMessageSent { get; set; }
        public WhatsAppChatListMessageStatusEnum MessageSentStatus { get; set; }
    }
}
