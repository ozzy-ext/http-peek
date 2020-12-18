namespace HttpPeek.Vms
{
    public class RequestNodeVm : RequestsNodeVm
    {
        public virtual string Method { get; set; }

        public virtual string Path { get; set; }

        public virtual RequestBodyVm Body { get; set; } = new DefaultRequestBodyVm();
        public virtual RequestAuthVm Auth { get; set; } = new DefaultRequestAuthVm();
        public virtual RequestQueryVm Query { get; } = new RequestQueryVm();
        public virtual RequestHeadersVm Headers { get; } = new RequestHeadersVm();
    }
}