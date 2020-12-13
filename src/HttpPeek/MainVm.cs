using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek
{
    public class MainVm : DialogVm
    {
        public virtual ProjectVm CurrentProject { get; set; }

        public MainVm()
        {
        }
    }
}
