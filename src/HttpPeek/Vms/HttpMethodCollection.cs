using System.Collections.ObjectModel;

namespace HttpPeek.Vms
{
    public class HttpMethodCollection : Collection<string>
    {
        public HttpMethodCollection()
        {
            Add("GET");
            Add("POST");
            Add("PUT");
            Add("PATCH");
            Add("DELETE");
            Add("OPTIONS");
            Add("HEAD");
        }
    }
}
