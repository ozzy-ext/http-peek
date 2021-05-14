using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignProjectVm : ProjectVm
    {
        public DesignProjectVm() 
            : base(new DesignTimeVmFactory())
        {
            Title = "Test project";

            Requests = VmFactory.Create<DesignRequestFolderNodeVm>();

        }
    }
}