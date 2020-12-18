using System.Collections.ObjectModel;

namespace HttpPeek.Vms
{
    public class RequestFolderNodeVm : RequestsNodeVm
    {
        
        public ObservableCollection<RequestsNodeVm> Children { get; } = new ObservableCollection<RequestsNodeVm>();
    }
}