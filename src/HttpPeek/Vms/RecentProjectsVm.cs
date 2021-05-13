using System;
using System.Collections.ObjectModel;
using HttpPeek.Logic;
using MyLab.Wpf;

namespace HttpPeek.Vms
{

    public class RecentProjectsVm : ViewModel
    {
        private readonly IRecentProjects _recentProjects;

        public ObservableCollection<RecentProjectVm> Projects { get; }
            = new ObservableCollection<RecentProjectVm>();

        public RecentProjectsVm(IRecentProjects recentProjects)
        {
            _recentProjects = recentProjects ?? throw new ArgumentNullException(nameof(recentProjects));
            _recentProjects.ProjectListChanged += (sender, args) => UpdateProjectList();

            UpdateProjectList();
        }

        void UpdateProjectList()
        {
            Projects.Clear();
            foreach (var projectPath in _recentProjects.GetProjects())
            {
                Projects.Add(new RecentProjectVm
                {
                    Path = projectPath
                    //OpenCmd = 
                });
            }
        }
    }
}
