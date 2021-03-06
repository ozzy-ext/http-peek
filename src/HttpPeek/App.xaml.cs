﻿using System.Windows;
using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.CreateGuiApp()
                .Start<MainVm>();

        }
    }
}
