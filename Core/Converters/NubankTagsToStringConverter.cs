using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class NubankTagsToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tags = value as List<string>;
            if (tags == null)
                return string.Empty;

            var textTags = string.Empty;

            foreach (var tag in tags)
                textTags += $"#{tag} ";

            return textTags.Trim();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
