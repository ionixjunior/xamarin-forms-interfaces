using System;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class NubankPriceToLocalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var price = value as double?;
            if (!price.HasValue)
                return string.Empty;

            return price.Value.ToString("C2", new CultureInfo("pt-BR"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
