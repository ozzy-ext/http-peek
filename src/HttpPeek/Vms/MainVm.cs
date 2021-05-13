using HttpPeek.Design;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class MainVm : DialogVm
    {
        private readonly IViewModelFactory _vmFactory;
        public virtual ProjectVm CurrentProject { get; set; }
        public virtual RecentProjectsVm RecentProjects { get; set; }
        public virtual FavoriteProjectsVm FavoriteProjects { get; set; }

        public MainVm(IViewModelFactory vmFactory)
        {
            _vmFactory = vmFactory;
            Title = "Home";
            CurrentProject = vmFactory.Create<DesignProjectVm>();
            RecentProjects = vmFactory.Create<DesignRecentProjectsVm>();
            FavoriteProjects= vmFactory.Create<DesignFavoriteProjectsVm>();
        }
    }
}
