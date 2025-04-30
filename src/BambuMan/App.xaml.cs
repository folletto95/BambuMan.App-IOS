namespace BambuMan
{
    public partial class App
    {
        private readonly AppShell appShell;

        public App(AppShell appShell)
        {
            InitializeComponent();
            this.appShell = appShell;

            Preferences.Default.Set("default_buy_date", $"{DateTime.Today:yyyy-MM-dd}");
        }

        protected override Window CreateWindow(IActivationState? activationState) => new(appShell);
    }
}