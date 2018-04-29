using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface IWhatsApp
    {
        IList<WhatsAppChatListModel> GetChats();
        WhatsAppInfoModel GetInfo();
    }
}
