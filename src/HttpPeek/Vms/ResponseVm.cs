using System;
using System.Net;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class ResponseVm : ViewModel
    {
        public HttpStatusCode StatusCode { get; set; }

        public long Size { get; set; }

        public TimeSpan Duration { get; set; }
    }
}