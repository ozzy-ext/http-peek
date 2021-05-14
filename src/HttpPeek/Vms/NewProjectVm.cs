using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class NewProjectVm : DialogVm
    {
        public virtual string ProjectName { get; set; }

        public NewProjectVm()
        {
        }

        protected override bool ValidatePositiveClosing()
        {
            return !string.IsNullOrWhiteSpace(ProjectName);
        }
    }
}
