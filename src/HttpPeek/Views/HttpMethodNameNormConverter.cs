using MyLab.Wpf.Converters;

namespace HttpPeek.Views
{
    public class HttpMethodNameNormConverter : ValueConverter<string, string>
    {
        public bool Short { get; set; }

        protected override string Convert(string source, object parameter)
        {
            switch (source.ToLower())
            {
                case "get": return "GET";
                case "post": return "POST";
                case "push": return "PUSH";
                case "put": return "PUT";
                case "patch": return Short ? "PTCH" : "PATCH";
                case "delete": return Short ? "DEL" : "DELETE";
                case "options": return Short ? "OPT" : "OPTIONS";
                case "head": return "HEAD";
                default: return source;
            }
        }

        protected override string ConvertBack(string dest, object parameter)
        {
            if (dest == null)
                return null;

            var d = dest.ToUpper();
            switch (d)
            {
                case "PTCH": return "PATCH";
                case "DEL": return "DELETE";
                case "OPT": return "OPTIONS";
                default: return d;
            }
        }
    }
}
