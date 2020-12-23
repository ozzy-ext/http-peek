using System;
using System.Net;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignResponseVm : ResponseVm
    {
        public DesignResponseVm()
        {
            WebClient cl = new WebClient();

            var resp =cl.DownloadData("http://ya.ru");

            StatusCode = HttpStatusCode.OK;
            Size = 12345;
            Duration = TimeSpan.FromSeconds(25);

            var contentPresenter = new BrowserPreviewResponseContentPresenterVm {Content = resp };

            ContentPresenters.Add(contentPresenter);

            SelectedContentPresenter = contentPresenter;
        }
    }
}
