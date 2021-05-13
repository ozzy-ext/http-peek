using HttpPeek.Logic;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignMainMenuFileVm : MainMenuFileVm
    {
        static IRecentProjects CreateRecentProjectStorage()
        {
            var s = new MemoryRecentProjects();
            s.AddProject("c:\\\\some-path-project\\yande.htp");
            s.AddProject("c:\\\\some-path-project\\google.htp");

            return s;
        }

        public DesignMainMenuFileVm() : base(CreateRecentProjectStorage())
        {
        }
    }
}
