using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class NewProjectVm : DialogVm
    {
        public virtual string ProjectName { get; set; }

        public NewProjectVm(IDialogCloser closer) 
            : base(new EmptyDialogLogic(), closer)
        {
        }
    }
}
