
 

namespace MAUI_OpenBrowser
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            lstUrls.ItemsSource = new List<WebSites>()
            {
               new WebSites("Web Net Helper","https://www.webnethelper.com"),
            new WebSites("DNC","https://www.dotnetcurry.com"),
            new WebSites("DevC","https://www.devcurry.com.com"),
            };
        }

        private async void btnOpenBrowser_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Get selected web site name
                Uri uri = new Uri(((WebSites)lstUrls.SelectedItem).URL);

                // Set the Browser Open Actions
                BrowserLaunchOptions options= new BrowserLaunchOptions() 
                {
                   LaunchMode = BrowserLaunchMode.SystemPreferred,
                   PreferredToolbarColor = Colors.SandyBrown
                }    ;
                await Browser.Default.OpenAsync(uri, options);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }
    }


    internal class WebSites
    {
        public WebSites(string siteName, string url)
        {
            SiteName= siteName;
            URL= url;

        }

        public string SiteName { get; set; }
        public string URL { get; set; }
    }
}