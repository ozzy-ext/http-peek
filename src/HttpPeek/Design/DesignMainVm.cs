using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignMainVm : MainVm
    {
        public DesignMainVm() : base(new DesignTimeVmFactory(), null, null) 
        {
            CurrentProject = new DesignProjectVm();
            RecentProjects = new DesignRecentProjectsVm();
            Title = "Home (design)";
        }
    }
}
