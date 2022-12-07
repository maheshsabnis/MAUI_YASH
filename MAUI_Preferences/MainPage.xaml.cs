namespace MAUI_Preferences
{
    public partial class MainPage : ContentPage
    {
        private bool _CanReceiveNotifications = false;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public bool CanReceiveNotifications 
        {
            get => _CanReceiveNotifications;
            set
            {
                _CanReceiveNotifications = value;
                OnPropertyChanged(nameof(CanReceiveNotifications));
            }
        }

        private void btnSaveChoice_Clicked(object sender, EventArgs e)
        {
            Preferences.Default.Set<bool>("IsNotificationEnabled", CanReceiveNotifications);
            OnPropertyChanged(nameof(CanReceiveNotifications));
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            if (Preferences.Default.ContainsKey("IsNotificationEnabled"))
            {
                // if the value (actual value) received from Preferences for the Key is different than
                // the default value the the actual value will be used
                CanReceiveNotifications = Preferences.Default.Get<bool>("IsNotificationEnabled", false);
                OnPropertyChanged(nameof(CanReceiveNotifications));
            }
             
        }
    }
}