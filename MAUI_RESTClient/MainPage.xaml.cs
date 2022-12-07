using MAUI_RESTClient.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace MAUI_RESTClient
{
    public partial class MainPage : ContentPage
    {
        // Specify the Service URL as per the Platform (This is MAndatory for Android Emulator)

        //public static string APIBaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";

        public static string APIBaseAddress = "https://expensesservicemaui.azurewebsites.net";


       Expenses expenses;
        HttpClient client;
        public MainPage()
        {
            InitializeComponent();
            expenses = new Expenses();
            this.BindingContext = expenses;

        }

        private async void btnSaveExpenses_Clicked(object sender, EventArgs e)
        {
            try
            {
                List<Expenses> expensesDetails = new List<Expenses>();
                client = new HttpClient();
                var Response = 
                     await client.PostAsJsonAsync<Expenses>($"{APIBaseAddress}/api/Expenses", expenses);

                if (Response.IsSuccessStatusCode)
                {
                      expensesDetails = await Response.Content.ReadFromJsonAsync<List<Expenses>>();
                }
               
                await DisplayAlert("Received Data", JsonSerializer.Serialize(expensesDetails), "Close");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }

        private async void btnGetExpenses_Clicked(object sender, EventArgs e)
        {
            try
            {
                client = new HttpClient();
                var expensesResponse = await client.GetFromJsonAsync<List<Expenses>>($"{APIBaseAddress}/api/Expenses");
                await DisplayAlert("Received Data", JsonSerializer.Serialize(expensesResponse) ,"Close");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }
    }
}