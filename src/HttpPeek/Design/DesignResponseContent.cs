using System;
using System.Net;

namespace HttpPeek.Design
{
    static class DesignResponseContent
    {
        public static readonly Lazy<byte[]> Content;

        static DesignResponseContent()
        {   
            Content = new Lazy<byte[]>(() =>
            {
                WebClient cl = new WebClient();

                var resp = cl.DownloadData("http://ya.ru");

                return resp;
            });
        }
    }
}