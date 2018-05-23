using System;

namespace Core.Models
{
    public class WhatsAppReceivedMessageModel : WhatsAppMessageModel
    {
        public int TotalUnread { get; set; }
    }
}
