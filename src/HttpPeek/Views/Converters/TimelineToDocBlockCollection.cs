using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Media;
using HttpPeek.Vms;
using MyLab.Wpf.Converters;

namespace HttpPeek.Views.Converters
{
    public class TimelineToDocBlockCollection : ValueConverter<ResponseTimeline, IEnumerable<Block>>
    {
        public string InfoPrefix { get; set; }
        public string RequestPrefix { get; set; }
        public string ResponsePrefix { get; set; }

        public Brush InfoColor { get; set; }
        public Brush RequestColor { get; set; }
        public Brush ResponseColor { get; set; }

        protected override IEnumerable<Block> Convert(ResponseTimeline source, object parameter)
        {
            if(source == null)
                return Enumerable.Empty<Block>();

            return source.Select(TimelineItemToParagraph);
        }

        Paragraph TimelineItemToParagraph(TimelineItemVm item)
        {
            var p = new Paragraph();

            if (!string.IsNullOrWhiteSpace(item.Title))
            {
                var bold = new Bold();

                bold.Inlines.AddRange(PrepareText(item.Title, item.TilelineItemType));

                p.Inlines.Add(bold);
            }

            if (!string.IsNullOrWhiteSpace(item.Message))
            {
                p.Inlines.AddRange(PrepareText(item.Message, item.TilelineItemType));
            }

            return p;
        }

        Inline[] PrepareText(string text, TimelineItemType itemType)
        {
            return text
                .Split('\n')
                .Select(s => TimelineItemTypeToPrefix(itemType) + " " + s)
                .Select(s => new Run(s + "\n") { Foreground = TimelineItemTypeToColor(itemType) })
                .Cast<Inline>()
                .ToArray();
        }

        string TimelineItemTypeToPrefix(TimelineItemType itemType)
        {
            switch (itemType)
            {
                case TimelineItemType.Info:
                    return InfoPrefix;
                case TimelineItemType.Request:
                    return RequestPrefix;
                case TimelineItemType.Response:
                    return ResponsePrefix;
                default:
                    return String.Empty;
            }
        }

        Brush TimelineItemTypeToColor(TimelineItemType itemType)
        {
            switch (itemType)
            {
                case TimelineItemType.Info:
                    return InfoColor;
                case TimelineItemType.Request:
                    return RequestColor;
                case TimelineItemType.Response:
                    return ResponseColor;
                default:
                    return new SolidColorBrush(Colors.Black);
            }
        }
    }
}
