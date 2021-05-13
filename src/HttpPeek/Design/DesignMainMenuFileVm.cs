using HttpPeek.Logic;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignMainMenuFileVm : MainMenuFileVm
    {
        static IRecentProjectStorage CreateRecentProjectStorage()
        {
            var s = new MemoryRecentProjectStorage();
            s.AddProject("c:\\\\some-path-project\\yande.htp");
            s.AddProject("c:\\\\some-path-project\\google.htp");

            return s;
        }

        public DesignMainMenuFileVm() : base(CreateRecentProjectStorage())
        {
        }
    }
}
