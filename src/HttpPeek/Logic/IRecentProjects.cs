using System;
using System.Collections.Generic;
using System.Linq;

namespace HttpPeek.Logic
{
    public interface IRecentProjects
    {
        event EventHandler ProjectListChanged;
        IEnumerable<string> GetProjects();
        void AddProject(string path);
    }

    class MemoryRecentProjects : IRecentProjects
    {
        private const int Size = 5;

        readonly List<string> _items = new List<string>(Size);

        public event EventHandler ProjectListChanged;

        public IEnumerable<string> GetProjects()
        {
            return _items.ToArray();
        }

        public void AddProject(string path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));

            _items.Remove(path);
            _items.Insert(0, path);

            while (_items.Count > Size)
                _items.RemoveAt(_items.Count-1);

            OnProjectListChanged();
        }

        protected virtual void OnProjectListChanged()
        {
            ProjectListChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
