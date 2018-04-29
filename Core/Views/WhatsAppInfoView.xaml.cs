using Xamarin.Forms;

namespace Core.Views
{
    public partial class WhatsAppInfoView : ContentPage
    {
        public WhatsAppInfoView()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();
            MainScroll.Parallax();
		}
	}
}
