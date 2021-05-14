using System.Linq;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestNodeVm : RequestsNodeVm
    {
        public virtual string Method { get; set; }

        public virtual string Path { get; set; }

        public virtual RequestBodyVm SelectedBody { get; set; }
        public virtual RequestAuthVm SelectedAuth { get; set; }
        public virtual RequestQueryVm Query { get; } = new RequestQueryVm();
        public virtual RequestHeadersVm Headers { get; } = new RequestHeadersVm();

        public RequestBodyCollection Bodies { get; }
        public RequestAuthCollection Auths { get; }

        public virtual ResponseVm Response { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestNodeVm"/>
        /// </summary>
        public RequestNodeVm(IVmFactory f)
        {
            Bodies = new RequestBodyCollection(f);
            SelectedBody = Bodies.OfType<NoBodyRequestBodyVm>().First();

            Auths = new RequestAuthCollection(f);
            SelectedAuth = Auths.OfType<NoAuthRequestAuthVm>().First();

        }
    }
}