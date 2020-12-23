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

            Timeline.Add(new TimelineItemVm{ TilelineItemType = TimelineItemType.Info, Message = "Preparing request to http://yandex.ru\nCurrent time is 2020 - 12 - 23T20:19:21.963Z\nUsing libcurl / 7.69.1 - DEV OpenSSL / 1.1.1d zlib / 1.2.11 WinIDN libssh2 / 1.9.0_DEV nghttp2 / 1.40.0\nUsing default HTTP version\nDisable timeout\nEnable automatic URL encoding\nDisable SSL validation\nEnable cookie sending with jar of 0 cookies\nTrying 10.251.86.176:80...\nConnected to dev - mark - 2.eisnot.ru(10.251.86.176) port 80(#1)"});
            Timeline.Add(new TimelineItemVm{ TilelineItemType = TimelineItemType.Request, Message = "GET /somepath HTTP/1.1\nHost: yandex.ru\nUser - Agent: HttpPeek\nAccept: */*"});
            Timeline.Add(new TimelineItemVm{ TilelineItemType = TimelineItemType.Info, Message = "Mark bundle as not supporting multiuse" });
            Timeline.Add(new TimelineItemVm{ TilelineItemType = TimelineItemType.Response, Message = "HTTP/1.1 200 OK\nServer: nginx / 1.16.1\nDate: Wed,\n23 Dec 2020 20:19:22 GMT\nContent - Type: application/json\nTransfer - Encoding: chunked\nConnection: keep - alive\nVary: Accept - Encoding" });
            Timeline.Add(new TimelineItemVm{ TilelineItemType = TimelineItemType.Info, Message = "Received 1177 B chunk\nReceived 2.9 KB chunk\nConnection #1 to host dev-mark-2.eisnot.ru left intact" });
        }
    }
}
