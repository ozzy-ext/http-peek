using HttpPeek.Design;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainVm : DialogVm
    {
        private readonly IVmFactory _vmFactory;
        private readonly IDialogManager _dialogManager;
        public virtual ProjectVm CurrentProject { get; set; }
        public virtual RecentProjectsVm RecentProjects { get; set; }
        public virtual FavoriteProjectsVm FavoriteProjects { get; set; }

        public VmCommand NewProjectCmd { get; }
        public VmCommand OpenProjectCmd { get; }
        public VmCommand ReloadProjectCmd { get; }
        public VmCommand ExitProjectCmd { get; private set; }

        public MainVm(IVmFactory vmFactory, IDialogManager dialogManager, IDialogCloser closer)
            : base(new EmptyDialogLogic(), closer)
        {
            _vmFactory = vmFactory;
            _dialogManager = dialogManager;
            CurrentProject = vmFactory.Create<DesignProjectVm>();
            RecentProjects = vmFactory.Create<DesignRecentProjectsVm>();
            FavoriteProjects= vmFactory.Create<DesignFavoriteProjectsVm>();

            NewProjectCmd = new VmCommand(() =>
            {
                if (TryCloseCurrentProject())
                {
                    ShowNewProjectDlg();
                }
            });

            OpenProjectCmd = new VmCommand(() =>
            {
                if (TryCloseCurrentProject())
                {
                    ShowOpenProjectDlg();
                }
            });

            ReloadProjectCmd = new VmCommand(() =>
            {
                if (TryCloseCurrentProject())
                {
                    ReloadCurentProject();
                }
            });

            ExitProjectCmd = new VmCommand(() =>
            {
                if (TryCloseCurrentProject())
                {
                    _dialogManager.Close(this);
                }
            });
        }

        private void ReloadCurentProject()
        {
            throw new System.NotImplementedException();
        }

        private void ShowOpenProjectDlg()
        {
            throw new System.NotImplementedException();
        }

        private void ShowNewProjectDlg()
        {
            var newProjDlg = _vmFactory.CreateChild<NewProjectVm>(this);
            if (_dialogManager.ShowDialog(newProjDlg).GetValueOrDefault())
            {

            }
        }
        
        private bool TryCloseCurrentProject()
        {
            return true;
        }
    }
}
