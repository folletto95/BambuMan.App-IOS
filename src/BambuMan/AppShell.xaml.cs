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
        protected override bool OnBackButtonPressed()
        {
            if (Current.CurrentState.Location.OriginalString == "//MainPage") return false;
            
            Current.GoToAsync("//MainPage", true);
            return true;
        }

    }
}
