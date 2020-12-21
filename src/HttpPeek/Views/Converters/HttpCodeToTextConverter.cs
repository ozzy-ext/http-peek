using System.Net;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views.Converters
{
    public class HttpCodeToTextConverter : ValueConverter<HttpStatusCode, string>
    {
        protected override string Convert(HttpStatusCode source, object parameter)
        {
            return $"{source:D} {source:G}";
        }
    }
}