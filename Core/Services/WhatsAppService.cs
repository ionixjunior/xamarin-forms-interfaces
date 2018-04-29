using System;
using System.Collections.Generic;
using Core.Enums;
using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class WhatsAppService : IWhatsApp
    {
        private IList<WhatsAppChatListModel> _chats;

        public WhatsAppService()
        {
            _chats = new List<WhatsAppChatListModel>();

            _chats.Add(GetChat(
                photo: "http://www.maisopiniao.com/wp-content/uploads/bola_futebol-150x150.jpg",
                isGroup: true,
                groupName: "Patota",
                sentFrom: "Luiz Pereira:",
                createdAt: DateTimeOffset.Now,
                message: "O jogo ficou confirmado para quarta??",
                isMuted: true,
                isRead: false,
                totalUnread: 9,
                isMessageSent: false,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.None
            ));

            _chats.Add(GetChat(
                photo: "https://i.imgflip.com/2/e4t4k.jpg",
                isGroup: false,
                groupName: null,
                sentFrom: "Marty McFly",
                createdAt: DateTimeOffset.Now.AddDays(-1),
                message: "If you put your mind to it, you can accomplish anything.",
                isMuted: false,
                isRead: true,
                totalUnread: 0,
                isMessageSent: false,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.None
            ));

            _chats.Add(GetChat(
                photo: "http://frostsnow.com/assets/thumbnails/1a/1a6bec3fe740466740d7836a3915284b.jpg",
                isGroup: false,
                groupName: null,
                sentFrom: "Dr. Emmett Brown",
                createdAt: DateTimeOffset.Now.AddDays(-2),
                message: "Roads? Where we are going we don`t need roads",
                isMuted: false,
                isRead: false,
                totalUnread: 3,
                isMessageSent: false,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.None
            ));

            _chats.Add(GetChat(
                photo: "http://helixholidays.com/wp-content/uploads/2016/01/family-shutter2-1-150x150.jpg",
                isGroup: true,
                groupName: "Família",
                sentFrom: "+55 11 98877-6655:",
                createdAt: DateTimeOffset.Now.AddDays(-3),
                message: "Bom dia!",
                isMuted: true,
                isRead: false,
                totalUnread: 73,
                isMessageSent: false,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.None
            ));

            _chats.Add(GetChat(
                photo: "https://www.deveserisso.com.br/blog/wp-content/uploads/2016/12/series-anos-90-um-maluco-no-pedaco-150x150.jpg",
                isGroup: false,
                groupName: null,
                sentFrom: "Will",
                createdAt: DateTimeOffset.Now.AddDays(-4),
                message: "Cara, to precisando passar uns dias ai em bell-air",
                isMuted: false,
                isRead: true,
                totalUnread: 0,
                isMessageSent: true,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.Read
            ));

            _chats.Add(GetChat(
                photo: "http://br.lookbook.blog/wp-content/uploads/sites/3/2017/05/www.depoisdosquinze.comRochelle-150x150-0d003ba0a3e2aafc033832bea11fa06cefaac4cb.jpg",
                isGroup: false,
                groupName: null,
                sentFrom: "Rochelle",
                createdAt: DateTimeOffset.Now.AddDays(-5),
                message: "Eu não preciso disso, meu marido tem 2 empregos",
                isMuted: false,
                isRead: true,
                totalUnread: 0,
                isMessageSent: false,
                messageStatusEnum: WhatsAppChatListMessageStatusEnum.None
            ));
        }

        private WhatsAppChatListModel GetChat(
            string photo, 
            bool isGroup,
            string groupName,
            string sentFrom,
            DateTimeOffset createdAt,
            string message,
            bool isMuted,
            bool isRead,
            int totalUnread,
            bool isMessageSent,
            WhatsAppChatListMessageStatusEnum messageStatusEnum)
        {
            return new WhatsAppChatListModel()
            {
                Photo = photo,
                IsGroup = isGroup,
                GroupName = groupName,
                SentFrom = sentFrom,
                CreatedAt = createdAt,
                Message = message,
                IsMuted = isMuted,
                IsRead = isRead,
                TotalUnread = totalUnread,
                IsMessageSent = isMessageSent,
                MessageSentStatus = messageStatusEnum
            };
        }

        public IList<WhatsAppChatListModel> GetChats()
        {
            return _chats;
        }
    }
}
