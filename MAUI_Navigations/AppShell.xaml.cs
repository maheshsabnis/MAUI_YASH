namespace MAUI_Navigations
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register the Route
            Routing.RegisterRoute(nameof(FirstView), typeof(FirstView));
            Routing.RegisterRoute(nameof(SecondView), typeof(SecondView));
        }
    }
}