using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Core.Views
{
    public partial class TwitchHomeView : TabbedPage
    {
        public TwitchHomeView()
        {
            InitializeComponent();

            AbsoluteLayout.SetLayoutFlags(Video, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(Video, GetRightBottomPosition());
        }

        private Rectangle GetRightBottomPosition() => new Rectangle(1, 1, Video.WidthRequest, Video.HeightRequest);
        private Rectangle GetRightTopPosition() => new Rectangle(1, 0, Video.WidthRequest, Video.HeightRequest);
        private Rectangle GetLeftBottomPosition() => new Rectangle(0, 1, Video.WidthRequest, Video.HeightRequest);
        private Rectangle GetLeftTopPosition() => new Rectangle(0, 0, Video.WidthRequest, Video.HeightRequest);

        void PanGestureRecognizer_PanUpdated(System.Object sender, Xamarin.Forms.PanUpdatedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Status: {e.StatusType}");

            switch (e.StatusType)
            {
                case GestureStatus.Started:
                case GestureStatus.Running:
                    System.Diagnostics.Debug.WriteLine($"X: {e.TotalX} - Y: {e.TotalY}");
                    Video.TranslationX = e.TotalX;
                    Video.TranslationY = e.TotalY;
                    break;
                case GestureStatus.Completed:
                    var pageWidth = Width;
                    var pageHeight = Height;
                    var positionX = Video.X + Video.TranslationX;
                    var positionY = Video.Y + Video.TranslationY;
                    var halfWidthVideo = Video.WidthRequest / 2;
                    var halfHeightVideo = Video.HeightRequest / 2;

                    if (halfWidthVideo + positionX > pageWidth / 2)
                    {
                        // move video to the right
                        if (halfHeightVideo + positionY > pageHeight / 2)
                        {
                            // move video to the bottom
                            AbsoluteLayout.SetLayoutBounds(Video, GetRightBottomPosition());
                        }
                        else
                        {
                            // move video to the top
                            AbsoluteLayout.SetLayoutBounds(Video, GetRightTopPosition());
                        }
                    }
                    else
                    {
                        // move video to the left
                        if (halfHeightVideo + positionY > pageHeight / 2)
                        {
                            // move video to the bottom
                            AbsoluteLayout.SetLayoutBounds(Video, GetLeftBottomPosition());
                        }
                        else
                        {
                            // move video to the top
                            AbsoluteLayout.SetLayoutBounds(Video, GetLeftTopPosition());
                        }
                    }

                    System.Diagnostics.Debug.WriteLine($"Page width: {pageWidth} - Page height: {pageHeight}");

                    Video.TranslationX = 0;
                    Video.TranslationY = 0;
                    break;
            }
        }
    }
}
