using System.Linq.Expressions;
using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignRequestNodeVm : RequestNodeVm
    {
        public DesignRequestNodeVm()
        :base(new DesignTimeViewModelFactory())
        {
            Title = "yandex-2";
            Method = "post";
            Path = "http://yandex.ru/something";
        }
    }
}