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

            Headers.Add(new ResponseHeaderVm{Name = "Connection", Value = "Keep-Alive" });
            Headers.Add(new ResponseHeaderVm{Name = "Content-Encoding", Value = "gzip" });
            Headers.Add(new ResponseHeaderVm{Name = "Content-Type", Value = "text/html; charset=utf-8" });
            Headers.Add(new ResponseHeaderVm{Name = "Transfer-Encoding", Value = "chunked" });
        }
    }
}
