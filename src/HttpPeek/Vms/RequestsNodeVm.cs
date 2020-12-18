using System.Collections.ObjectModel;

namespace HttpPeek.Vms
{
    public class RequestsNodeVm : RequestsNodeBaseVm
    {
        
        public ObservableCollection<RequestsNodeBaseVm> Children { get; } = new ObservableCollection<RequestsNodeBaseVm>();
    }
}