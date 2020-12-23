using System.Collections.ObjectModel;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ResponseTimeline : ObservableCollection<TimelineItemVm>
    {
    }

    public class TimelineItemVm : ViewModel
    {
        public TimelineItemType TilelineItemType { get; set; }
        public string Message { get; set; }
    }

    public enum TimelineItemType
    {
        Undefined,
        Info,
        Request,
        Response
    }
}
