namespace MAUI_Navigations
{
    public partial class MainPage : ContentPage
    {

        public ContactDetails Details { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Details= new ContactDetails();
            // Bind all Public Properties to the UI 
            this.BindingContext= this;
        }

       

        private async void btnNavigateToFirst_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FirstView));
        }

        private async void btnNavigateToSecond_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SecondView));
        }

        private async void lstContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (ContactDetail)lstContacts.SelectedItem;

            // Define a Dictionary that will be used for containing Key:Value Pair
            // for the Route Parameters

            var navigationParameter = new Dictionary<string, object>
            {
                { "Contact", contact }
            };
            

            await Shell.Current.GoToAsync(nameof(FirstView), navigationParameter);
        }
    }
}