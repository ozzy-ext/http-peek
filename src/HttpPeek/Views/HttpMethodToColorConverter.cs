using System.Windows.Media;
using MyLab.Wpf;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views
{
    public class HttpMethodToColorConverter : ValueConverter<string, Brush>
    {
        public Brush GetBrush { get; set; }
        public Brush PostBrush { get; set; }
        public Brush PushBrush { get; set; }
        public Brush PutBrush { get; set; }
        public Brush PatchBrush { get; set; }
        public Brush DeleteBrush { get; set; }
        public Brush OptionsBrush { get; set; }
        public Brush HeadBrush { get; set; }
        public Brush DefaultBrush { get; set; }

        protected override Brush Convert(string source, object parameter)
        {
            switch (source.ToLower())
            {
                case "get": return GetBrush;
                case "post": return PostBrush;
                case "push": return PushBrush;
                case "put": return PutBrush;
                case "patch": return PatchBrush;
                case "delete": return DeleteBrush;
                case "options": return OptionsBrush;
                case "head": return HeadBrush;
                default: return DefaultBrush;
            }
        }
    }
}