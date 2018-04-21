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

            await NavigationService.NavigateAsync("NavigationPage/CorePage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<CorePage>();
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
