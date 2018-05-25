using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;
using Core.Models.WhatsApp;

namespace Core.Services
{
    public class WhatsAppService : IWhatsApp
    {
        private IList<ChatModel> _chats;
        private WhatsAppInfoModel _info;

        public WhatsAppService()
        {
            _chats = new List<ChatModel>();

            _chats.Add(GetChat(
                photo: "http://www.maisopiniao.com/wp-content/uploads/bola_futebol-150x150.jpg",
                groupName: "Patota",
                sentFrom: "Luiz Pereira:",
                createdAt: DateTimeOffset.Now,
                message: "O jogo ficou confirmado para quarta??",
                messageIcon: string.Empty,
                isMuted: true,
                totalUnread: 9
            ));

            _chats.Add(GetChat(
                photo: "https://i.imgflip.com/2/e4t4k.jpg",
                groupName: null,
                sentFrom: "Marty McFly",
                createdAt: DateTimeOffset.Now.AddDays(-1),
                message: "If you put your mind to it, you can accomplish anything.",
                messageIcon: string.Empty,
                isMuted: false,
                totalUnread: 0
            ));

            _chats.Add(GetChat(
                photo: "http://www.georgefiorini.eu/images/ritorno-al-futuro/doc-brown.jpg",
                groupName: null,
                sentFrom: "Dr. Emmett Brown",
                createdAt: DateTimeOffset.Now.AddDays(-2),
                message: "Roads? Where we are going we don`t need roads",
                messageIcon: string.Empty,
                isMuted: false,
                totalUnread: 3
            ));

            _chats.Add(GetChat(
                photo: "http://helixholidays.com/wp-content/uploads/2016/01/family-shutter2-1-150x150.jpg",
                groupName: "Família",
                sentFrom: "+55 11 98877-6655:",
                createdAt: DateTimeOffset.Now.AddDays(-3),
                message: "Bom dia!",
                messageIcon: string.Empty,
                isMuted: true,
                totalUnread: 73
            ));

            _chats.Add(GetChat(
                photo: "https://www.deveserisso.com.br/blog/wp-content/uploads/2016/12/series-anos-90-um-maluco-no-pedaco-150x150.jpg",
                groupName: null,
                sentFrom: "Will",
                createdAt: DateTimeOffset.Now.AddDays(-4),
                message: "Cara, to precisando passar uns dias ai em bell-air",
                messageIcon: "whatsapp_read",
                isMuted: false,
                totalUnread: 0
            ));

            _chats.Add(GetChat(
                photo: "http://br.lookbook.blog/wp-content/uploads/sites/3/2017/05/www.depoisdosquinze.comRochelle-150x150-0d003ba0a3e2aafc033832bea11fa06cefaac4cb.jpg",
                groupName: null,
                sentFrom: "Rochelle",
                createdAt: DateTimeOffset.Now.AddDays(-5),
                message: "Eu não preciso disso, meu marido tem 2 empregos, EU ME DEMIIIITOO",
                messageIcon: string.Empty,
                isMuted: false,
                totalUnread: 0
            ));


            // info
            _info = new WhatsAppInfoModel()
            {
                Phone = "http://profetirando.com.br/wp-content/uploads/2015/10/de-volta-para-o-futuro-profetirando6.jpg",
                Name = "Marty McFly",
                Photo = "+1 11 9943-2424",
                Status = "Available",
                StatusAt = DateTimeOffset.Now.AddDays(131433)
            };
        }

        //private WhatsAppChatListModel GetChat(
        //    string photo, 
        //    bool isGroup,
        //    string groupName,
        //    string sentFrom,
        //    DateTimeOffset createdAt,
        //    string message,
        //    bool isMuted,
        //    bool isRead,
        //    int totalUnread,
        //    bool isMessageSent,
        //    WhatsAppChatListMessageStatusEnum messageStatusEnum)
        //{
        //    return new WhatsAppChatListModel()
        //    {
        //        Photo = photo,
        //        IsGroup = isGroup,
        //        GroupName = groupName,
        //        SentFrom = sentFrom,
        //        CreatedAt = createdAt,
        //        Message = message,
        //        IsMuted = isMuted,
        //        IsRead = isRead,
        //        TotalUnread = totalUnread,
        //        IsMessageSent = isMessageSent,
        //        MessageSentStatus = messageStatusEnum
        //    };
        //}

        private ChatModel GetChat(
            string photo,
            string sentFrom,
            DateTimeOffset createdAt,
            string message, 
            string messageIcon,
            bool isMuted,
            int totalUnread,
            string groupName)
        {
            ChatModel chatModel = null;

            if (groupName != null)
                chatModel = new GroupChatModel() { GroupName = groupName };

            if (chatModel == null)
                chatModel = new ChatModel();
            
            chatModel.Photo = photo;
            chatModel.SentFrom = sentFrom;
            chatModel.CreatedAt = createdAt;
            chatModel.Message = message;
            chatModel.MessageIcon = messageIcon;
            chatModel.IsMuted = isMuted;
            chatModel.TotalUnread = totalUnread;

            return chatModel;
        }

        public IList<ChatModel> GetChats()
        {
            return _chats;
        }

        public WhatsAppInfoModel GetInfo()
        {
            return _info;
        }
    }
}
