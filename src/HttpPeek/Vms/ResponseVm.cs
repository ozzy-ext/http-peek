using System;
using System.Collections.ObjectModel;
using System.Net;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ResponseVm : ViewModel
    {
        public HttpStatusCode StatusCode { get; set; }

        public long Size { get; set; }

        public TimeSpan Duration { get; set; }

        public ObservableCollection<ResponseContentPresenterVm> ContentPresenters { get; } = new ObservableCollection<ResponseContentPresenterVm>();

        public virtual ResponseContentPresenterVm SelectedContentPresenter { get; set; }

        public ObservableCollection<ResponseHeaderVm> Headers { get;  } = new ObservableCollection<ResponseHeaderVm>();
    }
}