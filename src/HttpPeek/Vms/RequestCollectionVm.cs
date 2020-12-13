using System.Collections.ObjectModel;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestCollectionVm : ViewModel
    {
        public ObservableCollection<RequestCollectionVm> Collections { get; } = new ObservableCollection<RequestCollectionVm>();
        public ObservableCollection<RequestVm> Requests { get; } = new ObservableCollection<RequestVm>();

        public RequestCollectionVm()
        {
            
        }
    }
}