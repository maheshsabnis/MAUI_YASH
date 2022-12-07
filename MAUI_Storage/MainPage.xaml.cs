namespace MAUI_Storage
{
    public partial class MainPage : ContentPage
    {
         

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async void btnCreateKey_Clicked(object sender, EventArgs e)
        {
            try
            {
                await SecureStorage.Default.SetAsync("ACCESS_TOKEN", entryCreateKey.Text);
                entryCreateKey.Text = "";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error In Save",ex.Message,"Close");
            }
        }

        private async void btnReteieveKey_Clicked(object sender, EventArgs e)
        {
            try
            {
                var accessToken = await SecureStorage.GetAsync("ACCESS_TOKEN");
                entryGetKey.Text = accessToken;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error In Retrieve", ex.Message, "Close");
            }
        }
    }
}