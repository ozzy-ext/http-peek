using System.Collections.ObjectModel;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestAuthVm : ViewModel
    {
        protected RequestAuthVm()
        {
            
        }
    }

    public class RequestAuthCollection : Collection<RequestAuthVm>
    {
        public RequestAuthCollection(IVmFactory f)
        {
            Add(f.Create<BasicRequestAuthVm>());
            Add(f.Create<BearerTokenRequestAuthVm>());
            Add(f.Create<NoAuthRequestAuthVm>());
        }
    }

    public class NoAuthRequestAuthVm : RequestAuthVm
    {
        public NoAuthRequestAuthVm()
        {
            Title = "No Authentication";
        }
    }

    public class BasicRequestAuthVm : RequestAuthVm
    {
        public BasicRequestAuthVm()
        {
            Title = "Basic";
        }
    }

    public class BearerTokenRequestAuthVm : RequestAuthVm
    {
        public BearerTokenRequestAuthVm()
        {
            Title = "Bearer Token";
        }
    }
}