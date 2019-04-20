using Xamarin.Forms;
using System;

namespace Core.Views
{
    public partial class NetflixHomeView : ContentPage
    {
        private Color _defaultBarBackgroundColor;
        private Color _defaultBarTextColor;
        private NavigationPage _navigationPage;

        public NetflixHomeView()
        {
            InitializeComponent();

            _navigationPage = (NavigationPage)Application.Current.MainPage;
            _defaultBarBackgroundColor = _navigationPage.BarBackgroundColor;
            _defaultBarTextColor = _navigationPage.BarTextColor;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _navigationPage.BarBackgroundColor = Color.Black;
            _navigationPage.BarTextColor = Color.White;
        }

        protected override void OnDisappearing()
        {
            _navigationPage.BarBackgroundColor = _defaultBarBackgroundColor;
            _navigationPage.BarTextColor = _defaultBarTextColor;
            base.OnDisappearing();
        }

        private double _lastPositionYScroll = 0;

        private void AfterScroll(object sender, ScrolledEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.ScrollY);
            bool hasNavigationBar = true;

            if (IsScrollYGreaterThanLastPosition(e.ScrollY))
                hasNavigationBar = false;

            _lastPositionYScroll = e.ScrollY;
            NavigationPage.SetHasNavigationBar(this, hasNavigationBar);
        }

        private bool IsScrollYGreaterThanLastPosition(double scrollY)
        {
            if (IsScrollingAtStart(scrollY))
                return false;

            if (IsScrollingAtEnd(scrollY))
                return false;

            return IsScrollingDown(scrollY);
        }

        private bool IsScrollingAtStart(double scrollY)
        {
            return scrollY <= 0;
        }

        private bool IsScrollingAtEnd(double scrollY)
        {
            var height = scroll.Content.Height - _navigationPage.Height;
            return scrollY >= height;
        }

        private bool IsScrollingDown(double scrollY)
        {
            return scrollY > _lastPositionYScroll;
        }
    }
}
