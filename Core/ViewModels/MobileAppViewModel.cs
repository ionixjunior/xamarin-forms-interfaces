using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models;

namespace Core.ViewModels
{
    public class MobileAppViewModel : BaseViewModel
    {
        public ObservableCollection<MobileAppModel> Apps { get; private set; }

        public MobileAppViewModel(IMobileApp mobileApp)
        {
            Title = "Apps";

            Apps = new ObservableCollection<MobileAppModel>(
                mobileApp.GetApps()
            );
        }
    }
}
