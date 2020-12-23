using System.Text;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignBrowserPreviewResponseContentPresenterVm : BrowserPreviewResponseContentPresenterVm
    {
        public DesignBrowserPreviewResponseContentPresenterVm()
        {
            Content = Encoding.UTF8.GetString(DesignResponseContent.Content.Value);
        }
    }
}