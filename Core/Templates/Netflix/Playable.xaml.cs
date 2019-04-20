using Xamarin.Forms;

namespace Core.Templates.Netflix
{
    public partial class Playable : ContentView
    {
        public Playable()
        {
            InitializeComponent();
            playablePhoto.WidthRequest = Application.Current.MainPage.Width;
        }
    }
}
