using System;
using Core.Interfaces;
using Core.Models;

namespace Core.ViewModels
{
    public class WhatsAppInfoViewModel : BaseViewModel
    {
        private readonly IWhatsApp _whatsApp;

        private WhatsAppInfoModel _info;
        public WhatsAppInfoModel Info
        {
            get => _info;
            set => SetProperty(ref _info, value);
        }

        public WhatsAppInfoViewModel(IWhatsApp whatsApp)
        {
            _whatsApp = whatsApp;

            Title = "Contact Info";
            Info = _whatsApp.GetInfo();
        }
    }
}
