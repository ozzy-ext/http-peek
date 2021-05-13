namespace HttpPeek.Logic
{
    public class ProjectLink
    {
        public string Title { get; }
        public string Path { get; }

        public ProjectLink(string title, string path)
        {
            Title = title;
            Path = path;
        }
    }
}