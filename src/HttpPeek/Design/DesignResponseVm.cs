using System;
using System.Net;
using System.Text;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignResponseVm : ResponseVm
    {
        public DesignResponseVm()
        {
            StatusCode = HttpStatusCode.OK;
            Size = 12345;
            Duration = TimeSpan.FromSeconds(25);

            var strResp = Encoding.UTF8.GetString(DesignResponseContent.Content.Value);
            var browserCp = new BrowserPreviewResponseContentPresenterVm {Content = strResp };
            var rawCp = new RawResponseContentPresenterVm{Content = strResp};

            ContentPresenters.Add(browserCp);
            ContentPresenters.Add(rawCp);

            SelectedContentPresenter = browserCp;
        }
    }
}
