using BambuMan.UI;
using BambuMan.UI.Scan;

namespace BambuMan
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(ScanPage), typeof(ScanPage));

            InitializeComponent();
        }
    }
}
