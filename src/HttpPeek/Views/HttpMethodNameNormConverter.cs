using MyLab.Wpf;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views
{
    public class HttpMethodNameNormConverter : ValueConverter<string, string>
    {
        protected override string Convert(string source, object parameter)
        {
            switch (source.ToLower())
            {
                case "get": return "GET";
                case "post": return "POST";
                case "push": return "PUSH";
                case "put": return "PUT";
                case "patch": return "PTCH";
                case "delete": return "DEL";
                case "options": return "OPT";
                case "head": return "HEAD";
                default: return source;
            }
        }
    }
}
