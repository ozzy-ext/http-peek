using System;
using System.Collections.Generic;
using System.Text;
using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignNewProjectVm : NewProjectVm
    {
        public DesignNewProjectVm(IDialogCloser closer) : base(closer)
        {
            ProjectName = "My Project";
        }
    }
}
