using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignMainVm : MainVm
    {
        public DesignMainVm() : base(new DesignTimeVmFactory()) 
        {
            CurrentProject = new DesignProjectVm();
            RecentProjects = new DesignRecentProjectsVm();
            Title = "Home (design)";
        }
    }
}
