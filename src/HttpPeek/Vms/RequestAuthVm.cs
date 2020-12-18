using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestAuthVm : ViewModel
    {
        protected RequestAuthVm()
        {
            
        }
    }

    public class DefaultRequestAuthVm : RequestAuthVm
    {
        public DefaultRequestAuthVm()
        {
            Title = "Auth";
        }
    }
}