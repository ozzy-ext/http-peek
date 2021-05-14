using System.Windows;
using HttpPeek.Views;
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

            GuiApp.Create(this)
                .UseServiceConfiguration((cfg, srv) =>
                {
                    srv.AddViewBinding(r =>
                    {
                        r.Add<NewProjectDlg, NewProjectVm>();
                    });
                })
                .Start<MainVm>();

        }
    }
}
