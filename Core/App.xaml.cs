using Core.Interfaces;
using Core.Services;
using Core.ViewModels;
using Core.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;

namespace Core
{
    public partial class App : PrismApplication
    {
        public App() : base(null) {}
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer) {}

		protected override async void OnInitialized()
		{
            InitializeComponent();

            Device.SetFlags(new string[] { "MediaElement_Experimental", "Shapes_Experimental" });

            await NavigationService.NavigateAsync("NavigationPage/MobileAppView");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MobileAppView, MobileAppViewModel>();
            containerRegistry.RegisterForNavigation<WhatsAppChatListView, WhatsAppChatListViewModel>();
            containerRegistry.RegisterForNavigation<WhatsAppInfoView, WhatsAppInfoViewModel>();
            containerRegistry.RegisterForNavigation<NubankTimelineView, NubankTimelineViewModel>();
            containerRegistry.RegisterForNavigation<NetflixHomeView, NetflixHomeViewModel>();
            containerRegistry.RegisterForNavigation<TwitchHomeView, TwitchHomeViewModel>();
            containerRegistry.RegisterForNavigation<FacebookLoginView>();

            containerRegistry.RegisterSingleton<IMobileApp, MobileAppService>();
            containerRegistry.RegisterSingleton<IWhatsApp, WhatsAppService>();
            containerRegistry.RegisterSingleton<INubank, NubankService>();
            containerRegistry.RegisterSingleton<INetflix, NetflixService>();
            containerRegistry.RegisterSingleton<ITwitch, TwitchService>();
        }

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
