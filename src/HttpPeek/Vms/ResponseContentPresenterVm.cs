using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ResponseContentPresenterVm : ViewModel
    {
        public string Content { get; set; }

        protected ResponseContentPresenterVm()
        {
            
        }
    }

    public class BrowserPreviewResponseContentPresenterVm : ResponseContentPresenterVm
    {
        public BrowserPreviewResponseContentPresenterVm()
        {
            Title = "Browser";
        }
    }

    public class RawResponseContentPresenterVm : ResponseContentPresenterVm
    {
        public RawResponseContentPresenterVm()
        {
            Title = "Raw";
        }
    }
}