using System;
using System.Collections.ObjectModel;
using HttpPeek.Logic;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainMenuFileVm : ViewModel
    {
        private readonly IRecentProjectStorage _recentProjectStorage;

        public ObservableCollection<RecentProjectVm> RecentProjects { get; }
            = new ObservableCollection<RecentProjectVm>();

        public VmCommand NewProjectCmd { get; }
        public VmCommand OpenProjectCmd { get; }

        public VmCommand ExitCmd { get; }

        public MainMenuFileVm(IRecentProjectStorage recentProjectStorage)
        {
            _recentProjectStorage = recentProjectStorage ?? throw new ArgumentNullException(nameof(recentProjectStorage));

            UpdateProjectList();

            _recentProjectStorage.ProjectListChanged += (sender, args) => UpdateProjectList();

            
        }

        void UpdateProjectList()
        {
            RecentProjects.Clear();
            foreach (var projectPath in _recentProjectStorage.GetProjects())
            {
                RecentProjects.Add(new RecentProjectVm
                {
                    Path = projectPath
                    //OpenCmd = 
                });
            }
        }

    }
}
