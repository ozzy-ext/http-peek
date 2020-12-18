using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestsNodeVm : ViewModel
    {
        public virtual bool Expanded { get; set; }
        public virtual bool Selected { get; set; }

        protected RequestsNodeVm()
        {
            
        }
    }
}