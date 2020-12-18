using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ProjectVm : ViewModel
    {
        public RequestsNodeVm Requests { get; protected set; }

        public ProjectVm(IViewModelFactory vmFactory)
        {
            Requests = vmFactory.Create<RequestsNodeVm>();
        }
    }
}
