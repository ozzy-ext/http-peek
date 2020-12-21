using System;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views.Converters
{
    public class DurationToStringConverter : ValueConverter<TimeSpan, string>
    {
        protected override string Convert(TimeSpan dur, object parameter)
        {
            if (dur < TimeSpan.FromSeconds(1)) return $"{dur.TotalMilliseconds} ms";
            if (dur < TimeSpan.FromMinutes(1)) return $"{dur.TotalSeconds} s";
            if (dur < TimeSpan.FromHours(1)) return $"{dur.Minutes} min {dur.Seconds} sec";
            return dur.ToString("g");
        }
    }
}