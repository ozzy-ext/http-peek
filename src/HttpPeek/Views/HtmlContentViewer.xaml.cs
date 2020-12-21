using System.Reflection;
using System.Windows.Controls;
using System.Windows.Navigation;
using MyLab.Wpf;

namespace HttpPeek.Views
{
    /// <summary>
    /// Interaction logic for HtmlContentViewer.xaml
    /// </summary>
    public partial class HtmlContentViewer : UserControl
    {
        public HtmlContentViewer()
        {
            InitializeComponent();

            WebBrowser.Navigating += (sender, args) =>
            {
                if(args.NavigationMode != NavigationMode.New || args.Uri != null)
                    args.Cancel = true;
            };
            WebBrowser.HideScriptErrors(true);
        }

        
    }
}
