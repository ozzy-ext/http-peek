namespace HttpPeek.Design
{
    public class DesignMainVm : MainVm
    {
        public DesignMainVm()
        {
            CurrentProject = new DesignProjectVm();
            Title = "Home (design)";
        }
    }
}
