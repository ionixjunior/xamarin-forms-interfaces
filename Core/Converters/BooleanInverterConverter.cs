using System;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class BooleanInverterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var newValue = value as bool?;
            if (!newValue.HasValue)
                return false;

            return !newValue.Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
