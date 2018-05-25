using System;

namespace Core.Externsions
{
    public static class DateTimeOffsetExtension
    {
        public static string ToWhatsApp(this DateTimeOffset dateTime)
        {
            var now = DateTimeOffset.Now;

            if (dateTime.Date == DateTime.Today)
                return dateTime.ToString("t");

            var diffDays = (now.Date - dateTime.Date).Days;
            if (diffDays <= 6) {
                if (diffDays == 1) {
                    return "Ontem";
                }

                switch (dateTime.DayOfWeek)
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

            return dateTime.ToString("d");
        }
    }
}
