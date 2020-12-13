using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ProjectVm : ViewModel
    {
        public RequestCollectionVm RootCollection { get; protected set; }

        public ProjectVm(IViewModelFactory vmFactory)
        {
            RootCollection = vmFactory.Create<RequestCollectionVm>();
        }
    }
}
