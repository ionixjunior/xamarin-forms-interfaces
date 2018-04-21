using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class MobileAppService : IMobileApp
    {
        private IList<MobileAppModel> _apps;

        public MobileAppService()
        {
            _apps = new List<MobileAppModel>();

            _apps.Add(GetMobileApp("WhatsApp - Lista chats"));
        }

        private MobileAppModel GetMobileApp(string name)
        {
            return new MobileAppModel()
            {
                Name = name
            };
        }

        public IList<MobileAppModel> GetApps()
        {
            return _apps;
        }
    }
}
