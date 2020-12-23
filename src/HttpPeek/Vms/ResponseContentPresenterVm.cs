using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ResponseContentPresenterVm : ViewModel
    {
        public byte[] Content { get; set; }

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
}