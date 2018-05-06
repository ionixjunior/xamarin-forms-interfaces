using System;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class NubankDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dateTime = value as DateTimeOffset?;
            if (!dateTime.HasValue)
                return string.Empty;

            var now = DateTimeOffset.Now;

            if (dateTime.Value.Year == now.Year)
            {
                if (dateTime.Value.Month == now.Month)
                {
                    if (dateTime.Value.Day == now.Day)
                        return dateTime.Value.ToString("HH:mm");

                    if (dateTime.Value.Day == now.AddDays(-1).Day)
                        return "Ontem";

                    var dayOfWeek = dateTime.Value.DayOfWeek;
                    string textDayOfWeek = string.Empty;

                    switch (dayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            textDayOfWeek = "Domingo";
                            break;
                        case DayOfWeek.Monday:
                            textDayOfWeek = "Segunda";
                            break;
                        case DayOfWeek.Tuesday:
                            textDayOfWeek = "Terça";
                            break;
                        case DayOfWeek.Wednesday:
                            textDayOfWeek = "Quarta";
                            break;
                        case DayOfWeek.Thursday:
                            textDayOfWeek = "Quinta";
                            break;
                        case DayOfWeek.Friday:
                            textDayOfWeek = "Sexta";
                            break;
                        case DayOfWeek.Saturday:
                            textDayOfWeek = "Sábado";
                            break;
                    }

                    if (dateTime.Value.Day >= now.AddDays(-6).Day)
                        return textDayOfWeek;
                }

                return dateTime.Value.ToString("dd MMM");
            }

            return dateTime.Value.ToString("dd MMM yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
