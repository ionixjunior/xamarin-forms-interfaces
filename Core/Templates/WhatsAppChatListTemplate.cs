using System;
using Core.Models;
using Core.Templates.WhatsAppChatList;
using Xamarin.Forms;

namespace Core.Templates
{
    public class WhatsAppChatListTemplate : DataTemplateSelector
    {
        private DataTemplate _groupSentMessage;
        private DataTemplate _groupReceivedMessage;
        private DataTemplate _groupUnreadReceivedMessage;
        private DataTemplate _singleSentMessage;
        private DataTemplate _singleReceivedMessage;
        private DataTemplate _singleUnreadReceivedMessage;
        
        public WhatsAppChatListTemplate()
        {
            _groupSentMessage = new DataTemplate(typeof(GroupSentMessage));
            _groupReceivedMessage = new DataTemplate(typeof(GroupReceivedMessage));
            _groupUnreadReceivedMessage = new DataTemplate(typeof(GroupUnreadReceivedMessage));
            _singleSentMessage = new DataTemplate(typeof(SingleSentMessage));
            _singleReceivedMessage = new DataTemplate(typeof(SingleReceivedMessage));
            _singleUnreadReceivedMessage = new DataTemplate(typeof(SingleUnreadReceivedMessage));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as WhatsAppChatListModel;
            if (model == null)
                throw new InvalidCastException();

            if (model.IsGroup && model.IsMessageSent)
                return _groupSentMessage;

            if (model.IsGroup && model.IsRead)
                return _groupReceivedMessage;

            if (model.IsGroup && !model.IsRead)
                return _groupUnreadReceivedMessage;

            if (!model.IsGroup && model.IsMessageSent)
                return _singleSentMessage;

            if (!model.IsGroup && model.IsRead)
                return _singleReceivedMessage;

            if (!model.IsGroup && !model.IsRead)
                return _singleUnreadReceivedMessage;

            throw new InvalidOperationException();
        }
    }
}
