using System;
using System.Collections.Generic;
using Core.Models;
using Core.Models.WhatsApp;

namespace Core.Interfaces
{
    public interface IWhatsApp
    {
        IList<ChatModel> GetChats();
        WhatsAppInfoModel GetInfo();
    }
}
