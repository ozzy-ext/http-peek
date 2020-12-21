using System;
using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignResponseVm : ResponseVm
    {
        public DesignResponseVm()
        {
            Size = 12345;
            Duration = TimeSpan.FromSeconds(25);
        }
    }
}
