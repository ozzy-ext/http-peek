namespace HttpPeek.Vms
{
    public class RootRequestsNodeVm : RequestsNodeVm
    {
        private RequestsNodeBaseVm _selectedNode;

        public virtual RequestsNodeBaseVm SelectedNode
        {
            get => _selectedNode;
            set
            {
                _selectedNode = value;
                SelectedRequest = _selectedNode as RequestNodeVm;
            }
        }


        public virtual RequestNodeVm SelectedRequest { get; set; }

    }
}