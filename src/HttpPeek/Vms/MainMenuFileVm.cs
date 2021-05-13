using System;
using System.Collections.ObjectModel;
using HttpPeek.Logic;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainMenuFileVm : ViewModel
    {
        private readonly IRecentProjects _recentProjects;

        public ObservableCollection<RecentProjectVm> RecentProjects { get; }
            = new ObservableCollection<RecentProjectVm>();

        public VmCommand NewProjectCmd { get; }
        public VmCommand OpenProjectCmd { get; }

        public VmCommand ExitCmd { get; }

        public MainMenuFileVm(IRecentProjects recentProjects)
        {
            _recentProjects = recentProjects ?? throw new ArgumentNullException(nameof(recentProjects));

            UpdateProjectList();

            _recentProjects.ProjectListChanged += (sender, args) => UpdateProjectList();

            
        }

        void UpdateProjectList()
        {
            RecentProjects.Clear();
            foreach (var projectPath in _recentProjects.GetProjects())
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
