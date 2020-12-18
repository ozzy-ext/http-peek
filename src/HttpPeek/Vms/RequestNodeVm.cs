namespace HttpPeek.Vms
{
    public class RequestNodeVm : RequestsNodeBaseVm
    {
        public virtual string Method { get; set; }

        public virtual string Path { get; set; }
    }
}