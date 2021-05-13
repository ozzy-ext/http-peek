using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HttpPeek.Logic
{
    public interface IFavoriteProjects
    {
        event EventHandler ProjectListChanged;
        IEnumerable<Project> GetProjects();

        void AddProject(ProjectLink link);
        void RemoveProject(string title);
    }

    class MemoryFavoriteProjects : IFavoriteProjects
    {
        readonly List<Project> _projects = new List<Project>();

        public event EventHandler ProjectListChanged;
        public IEnumerable<Project> GetProjects()
        {
            return _projects.ToArray();
        }

        public void AddProject(ProjectLink link)
        {
            if(_projects.Any(p => p.Link.Title == link.Title))
                throw new InvalidOperationException("A project with the same title already exists");
            _projects.Add(new Project
            {
                Link = link,
                AddTime = DateTime.Now
            });

            OnProjectListChanged();
        }

        public void RemoveProject(string title)
        {
            if (_projects.RemoveAll(p => p.Link.Title == title) != 0)
            {
                OnProjectListChanged();
            }
        }

        protected virtual void OnProjectListChanged()
        {
            ProjectListChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
