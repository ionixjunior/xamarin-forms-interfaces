using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models;

namespace Core.ViewModels
{
    public class WhatsAppChatListViewModel : BaseViewModel
    {
        public ObservableCollection<WhatsAppChatListModel> Chats { get; set; }

        public WhatsAppChatListViewModel(IWhatsApp whatsApp)
        {
            Title = "Chats";

            Chats = new ObservableCollection<WhatsAppChatListModel>(
                whatsApp.GetChats()
            );
        }
    }
}
