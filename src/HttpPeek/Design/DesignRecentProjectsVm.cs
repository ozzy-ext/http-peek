using HttpPeek.Logic;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignRecentProjectsVm : RecentProjectsVm
    {
        static IRecentProjects CreateRecentProjectStorage()
        {
            var s = new MemoryRecentProjects();
            s.AddProject("c:\\\\some-path-project\\yande.htp");
            s.AddProject("c:\\\\some-path-project\\google.htp");

            return s;
        }

        public DesignRecentProjectsVm() : base(CreateRecentProjectStorage())
        {
        }
    }
}
