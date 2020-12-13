using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestVm : ViewModel
    {
        public virtual string Method { get; set; }

        public virtual string Path { get; set; }
    }
}