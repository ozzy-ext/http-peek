using HttpPeek.Design;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainVm : DialogVm
    {
        public virtual ProjectVm CurrentProject { get; set; }
        public virtual MainMenuFileVm MainMenuFile { get; set; }

        public MainVm()
        {
            Title = "Home";
            CurrentProject = new DesignProjectVm();
            MainMenuFile = new DesignMainMenuFileVm();
        }
    }
}
