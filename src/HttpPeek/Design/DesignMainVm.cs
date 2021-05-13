using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignMainVm : MainVm
    {
        public DesignMainVm()
        {
            CurrentProject = new DesignProjectVm();
            MainMenuFile = new DesignMainMenuFileVm();
            Title = "Home (design)";
        }
    }
}
