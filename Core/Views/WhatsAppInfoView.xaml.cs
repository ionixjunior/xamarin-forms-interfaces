using System.Threading.Tasks;
using Xamarin.Forms;

namespace Core.Views
{
    public partial class WhatsAppInfoView : ContentPage
    {
        public WhatsAppInfoView()
        {
            InitializeComponent();
            MainScroll.ParallaxView = HeaderView;
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();
            MainScroll.Parallax();
            //MainScroll.ScrollToAsync(0, 150, false);
		}

		protected override void OnSizeAllocated(double width, double height)
		{
            base.OnSizeAllocated(width, height);
            MainScroll.Parallax();
		}
	}
}
