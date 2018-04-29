using System;
using Xamarin.Forms;

namespace Core.Controls
{
    public class Badge : AbsoluteLayout
    {
        protected Label Label;
        protected CircleBox Box;

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                "Text", 
                typeof(String), 
                typeof(Badge), 
                ""
            );

        //Box color property
        public static readonly BindableProperty BoxColorProperty =
            BindableProperty.Create(
                "BoxColor", 
                typeof(Color), 
                typeof(Badge), 
                Color.Default
            );


        public Badge()
        {
            var size = 20;
            var fontSize = 14;

            HeightRequest = size;
            WidthRequest = size;

            // Box
            Box = new CircleBox
            {
                CornerRadius = HeightRequest / 2
            };

            Box.SetBinding(BackgroundColorProperty, new Binding("BoxColor", source: this));
            Children.Add(Box, new Rectangle(0, 0, 1.0, 1.0), AbsoluteLayoutFlags.All);

            // Label
            Label = new Label
            {
                TextColor = Color.White,
                FontSize = fontSize,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            Label.SetBinding(Label.TextProperty, new Binding("Text", BindingMode.OneWay, source: this));

            Children.Add(Label, new Rectangle(0, 0, 1.0, 1.0), AbsoluteLayoutFlags.All);

            // Auto width
            SetBinding(WidthRequestProperty, new Binding("Text", BindingMode.OneWay, new BadgeWidthConverter(WidthRequest), source: this));

            // If not value = hide
            SetBinding(IsVisibleProperty, new Binding("Text", BindingMode.OneWay, new BadgeVisibleValueConverter(), source: this));

            // Default color
            BoxColor = Color.Red;
        }

        // Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Color of the box
        public Color BoxColor
        {
            get { return (Color)GetValue(BoxColorProperty); }
            set { SetValue(BoxColorProperty, value); }
        }

    }

    class BadgeWidthConverter : IValueConverter
    {

        // Width ratio.
        const double widthRatio = 0.33;

        //Width of the base.
        readonly double baseWidth;

        public BadgeWidthConverter(double baseWidth)
        {
            this.baseWidth = baseWidth;
        }


        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = value as string;
            if ((text != null) && (text.Length > 1))
            {
                return baseWidth * (1 + widthRatio * (text.Length - 1));
            }
            return baseWidth;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class BadgeVisibleValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = value as string;
            return !String.IsNullOrEmpty(text);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
