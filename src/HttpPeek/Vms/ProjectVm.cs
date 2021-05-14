using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ProjectVm : ViewModel
    {
        public IVmFactory VmFactory { get; }
        public RootRequestFolderNodeVm Requests { get; protected set; }

        public ProjectVm(IVmFactory vmFactory)
        {
            VmFactory = vmFactory;
            Requests = vmFactory.Create<RootRequestFolderNodeVm>();
        }
    }
}
