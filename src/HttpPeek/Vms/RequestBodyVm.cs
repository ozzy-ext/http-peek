using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestBodyVm : ViewModel
    {
        protected RequestBodyVm()
        {
            
        }
    }

    public class DefaultRequestBodyVm : RequestBodyVm
    {
        public DefaultRequestBodyVm()
        {
            Title = "Body";
        }
    }
}