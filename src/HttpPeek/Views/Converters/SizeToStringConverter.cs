using MyLab.Wpf.Converters;

namespace HttpPeek.Views.Converters
{
    public class SizeToStringConverter : ValueConverter<long, string>
    {
        protected override string Convert(long size, object parameter)
        {
            if (size >= 1024 && size < 1024*1024) return $"{size/1024} KB";
            if (size >= 1024 * 1024) return $"{size/(1024*1024)} MB";

            return $"{size} B";
        }
    }
}
