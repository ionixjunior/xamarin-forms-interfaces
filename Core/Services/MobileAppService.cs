using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;
using Core.ViewModels;
using Core.Views;

namespace Core.Services
{
    public class MobileAppService : IMobileApp
    {
        private IList<MobileAppModel> _apps;

        public MobileAppService()
        {
            _apps = new List<MobileAppModel>();

            _apps.Add(GetMobileApp(
                typeof(WhatsAppChatListView).Name,
                "WhatsApp - Lista chats",
                false
            ));

            _apps.Add(GetMobileApp(
                typeof(NubankTimelineView).Name,
                "Nubank - Timeline",
                false
            ));

            _apps.Add(GetMobileApp(
                typeof(WhatsAppInfoView).Name,
                "WhatsApp - Info",
                false
            ));

            _apps.Add(GetMobileApp(
                typeof(NetflixHomeView).Name,
                "Netflix - Home",
                false
            ));

            _apps.Add(GetMobileApp(
                $"NavigationPage/{typeof(TwitchHomeView).Name}",
                "Twitch - Home",
                true
            ));
        }

        private MobileAppModel GetMobileApp(
            string viewName,
            string name,
            bool useModalNavigation)
        {
            return new MobileAppModel()
            {
                ViewName = viewName,
                Name = name,
                UseModalNavigation = useModalNavigation
            };
        }

        public IList<MobileAppModel> GetApps()
        {
            return _apps;
        }
    }
}
