using System.Text;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignRawResponseContentPresenterVm : RawResponseContentPresenterVm
    {
        public DesignRawResponseContentPresenterVm()
        {
            Content = Encoding.UTF8.GetString(DesignResponseContent.Content.Value);
        }
    }
}