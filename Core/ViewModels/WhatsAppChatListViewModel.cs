using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models;
using Core.Models.WhatsApp;

namespace Core.ViewModels
{
    public class WhatsAppChatListViewModel : BaseViewModel
    {
        public ObservableCollection<ChatModel> Chats { get; set; }

        public WhatsAppChatListViewModel(IWhatsApp whatsApp)
        {
            Title = "Chats";

            var chats = whatsApp.GetChats();
            Chats = new ObservableCollection<ChatModel>(chats);
        }
    }
}
