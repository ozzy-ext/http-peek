namespace HttpPeek.Vms
{
    public class RootRequestFolderNodeVm : RequestFolderNodeVm
    {
        private RequestsNodeVm _selectedNode;

        public virtual RequestsNodeVm SelectedNode
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