using System;
using System.Net;
using System.Windows.Media;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views.Converters
{
    public class HttpCodeToColorConverter : ValueConverter<HttpStatusCode, Brush>
    {
        public Brush DefaultColor { get; set; }
        public Brush Color100 { get; set; }
        public Brush Color200 { get; set; }
        public Brush Color300 { get; set; }
        public Brush Color400 { get; set; }
        public Brush Color500 { get; set; }

        protected override Brush Convert(HttpStatusCode source, object parameter)
        {
            Brush resColor = null;

            int statusCode = (int) source;

            if (statusCode >= 500) resColor = Color500;
            else if (statusCode >= 400) resColor = Color400;
            else if (statusCode >= 300) resColor = Color300;
            else if (statusCode >= 200) resColor = Color200;
            else if (statusCode >= 100) resColor = Color100;

            return resColor ?? DefaultColor ?? new SolidColorBrush(Colors.Black);
        }
    }
}
