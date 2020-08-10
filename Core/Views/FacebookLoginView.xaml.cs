using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Core.Views
{
    public partial class FacebookLoginView : ContentPage
    {
        public FacebookLoginView()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            FieldContainer.TranslationX = Width;
            FieldContainer.IsVisible = true;
            ProfileContainer.TranslationY = 120;

            await Task.WhenAll(
                ProfileContainer.TranslateTo(ProfileContainer.TranslationX, 0, 400, easing: Easing.CubicInOut),
                FieldContainer.TranslateTo(0, FieldContainer.TranslationY, 400, easing: Easing.CubicInOut),
                Name.FadeTo(0, 400)
            );
        }
    }
}
