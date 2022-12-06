using MAUI_MVVM.Models;
using MAUI_MVVM.ViewModel;
using System.Text.Json;

namespace MAUI_MVVM
{
    public partial class MainPage : ContentPage
    {
       // Expenses expenses;
       /// <summary>
       /// Inject the VM in View
       /// </summary>
       /// <param name="vm"></param>
        public MainPage(ExpensesViewModel vm)
        {
            InitializeComponent();
         //   expenses = new Expenses();  
           // this.BindingContext= expenses;
           
            // Bind the ViewModel instance with the View 
           this.BindingContext= vm;
        }

        //private async void btnSaveExpenses_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Info", JsonSerializer.Serialize(expenses), "Ok");
 
        //}
    }
}