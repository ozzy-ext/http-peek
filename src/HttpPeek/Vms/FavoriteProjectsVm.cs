using System.Collections.ObjectModel;
using HttpPeek.Logic;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class FavoriteProjectsVm : ViewModel
    {
        private readonly IFavoriteProjects _favoriteProjects;

        public ObservableCollection<Project> Projects { get; } = new ObservableCollection<Project>();

        public FavoriteProjectsVm(IFavoriteProjects favoriteProjects)
        {
            _favoriteProjects = favoriteProjects;
            _favoriteProjects.ProjectListChanged += (sender, args) => UpdateProjects();
            UpdateProjects();
        }

        void UpdateProjects()
        {
            Projects.Clear();
            foreach (var project in _favoriteProjects.GetProjects())
            {
                Projects.Add(project);
            }
        }
    }
}
