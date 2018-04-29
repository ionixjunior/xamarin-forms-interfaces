using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Prism.Navigation;
using Xamarin.Forms;

namespace Core.ViewModels
{
    public class MobileAppViewModel : BaseViewModel
    {
        private readonly INavigationService _navigation;

        public ObservableCollection<MobileAppModel> Apps { get; private set; }

        public Command SelectItemCommand { get; private set; }

        public MobileAppViewModel(INavigationService navigation,
                                  IMobileApp mobileApp)
        {
            _navigation = navigation;

            Title = "Apps";

            Apps = new ObservableCollection<MobileAppModel>(
                mobileApp.GetApps()
            );

            SelectItemCommand = new Command<MobileAppModel>(
                async (mobileAppModel) => await SelectItem(mobileAppModel)
            );
        }

        private async Task SelectItem(MobileAppModel mobileAppModel)
        {
            await _navigation.NavigateAsync(mobileAppModel.ViewName);
        }
    }
}
