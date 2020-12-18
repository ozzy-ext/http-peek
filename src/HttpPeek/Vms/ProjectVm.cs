using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ProjectVm : ViewModel
    {
        public IViewModelFactory VmFactory { get; }
        public RootRequestFolderNodeVm Requests { get; protected set; }

        public ProjectVm(IViewModelFactory vmFactory)
        {
            VmFactory = vmFactory;
            Requests = vmFactory.Create<RootRequestFolderNodeVm>();
        }
    }
}
