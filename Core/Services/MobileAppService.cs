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
                "WhatsApp - Lista chats"
            ));

            _apps.Add(GetMobileApp(
                typeof(NubankTimelineView).Name,
                "Nubank - Timeline"
            ));

            _apps.Add(GetMobileApp(
                typeof(WhatsAppInfoView).Name,
                "WhatsApp - Info"
            ));

            _apps.Add(GetMobileApp(
                typeof(NetflixHomeView).Name,
                "Netflix - Home"
            ));
        }

        private MobileAppModel GetMobileApp(
            string viewName,
            string name)
        {
            return new MobileAppModel()
            {
                ViewName = viewName,
                Name = name
            };
        }

        public IList<MobileAppModel> GetApps()
        {
            return _apps;
        }
    }
}
