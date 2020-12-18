using HttpPeek.Design;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainVm : DialogVm
    {
        public virtual ProjectVm CurrentProject { get; set; }

        public MainVm()
        {
            Title = "Home";
            CurrentProject = new DesignProjectVm();
        }
    }
}
