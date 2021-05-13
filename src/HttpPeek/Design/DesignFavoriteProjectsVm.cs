using HttpPeek.Logic;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignFavoriteProjectsVm : FavoriteProjectsVm
    {
        static IFavoriteProjects CreateFavoriteProjects()
        {
            var fp = new MemoryFavoriteProjects();

            fp.AddProject(new ProjectLink
            {
                Title = "Yandex",
                Path = "c:\\\\path-to-project\\yandex.htp"
            });

            fp.AddProject(new ProjectLink
            {
                Title = "Google",
                Path = "c:\\\\path-to-project\\google.htp"
            });

            return fp;
        }

        public DesignFavoriteProjectsVm() : base(CreateFavoriteProjects())
        {
        }
    }
}
