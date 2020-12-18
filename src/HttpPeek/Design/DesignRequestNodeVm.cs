using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignRequestNodeVm : RequestNodeVm
    {
        public DesignRequestNodeVm()
        {
            Title = "yandex-2";
            Method = "post";
            Path = "http://yandex.ru/something";
        }
    }
}