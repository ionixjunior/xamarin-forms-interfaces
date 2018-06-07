using System;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class WhatsAppDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dateTime = value as DateTimeOffset?;
            if (!dateTime.HasValue)
                return string.Empty;

            var now = DateTimeOffset.Now;

            if (dateTime.Value.Date == DateTime.Today)
                return dateTime.Value.ToString("t");

            var diffDays = (now.Date - dateTime.Value.Date).Days;
            if (diffDays <= 6)
            {
                if (diffDays == 1)
                {
                    return "Ontem";
                }

                switch (dateTime.Value.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        return "Domingo";
                    case DayOfWeek.Monday:
                        return "Segunda";
                    case DayOfWeek.Tuesday:
                        return "Terça";
                    case DayOfWeek.Wednesday:
                        return "Quarta";
                    case DayOfWeek.Thursday:
                        return "Quinta";
                    case DayOfWeek.Friday:
                        return "Sexta";
                    case DayOfWeek.Saturday:
                        return "Sábado";
                }
            }

            return dateTime.Value.ToString("d");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
