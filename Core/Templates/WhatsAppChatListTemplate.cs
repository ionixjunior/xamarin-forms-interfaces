using System;
using Core.Models;
using Core.Models.WhatsApp;
using Core.Templates.WhatsAppChatList;
using Xamarin.Forms;

namespace Core.Templates
{
    public class WhatsAppChatListTemplate : DataTemplateSelector
    {
        private DataTemplate _groupMessage;
        private DataTemplate _singleMessage;
        
        public WhatsAppChatListTemplate()
        {
            _groupMessage = new DataTemplate(typeof(GroupMessage));
            _singleMessage = new DataTemplate(typeof(SingleMessage));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as ChatModel;

            if (model is GroupChatModel)
                return _groupMessage;

            return _singleMessage;
        }
    }
}
