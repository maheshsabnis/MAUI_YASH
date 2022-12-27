namespace MAUI_AppActions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Subscribe to the OnAppActions event

            Microsoft.Maui.ApplicationModel.AppActions.OnAppAction += AppActions_OnAppAction;

            MainPage = new AppShell();
 
        }

        private void AppActions_OnAppAction(object sender, AppActionEventArgs e)
        {
            /// MAke sure that if the App is loaded with Shell object
            /// DeSubscribe to the App Actions 
            if (Application.Current != this && Application.Current is App)
            {
                Microsoft.Maui.ApplicationModel.AppActions.OnAppAction -= AppActions_OnAppAction;
                return;
            }

            

            // Ge5t the UI on the Main Thread
            MainThread.BeginInvokeOnMainThread(async () => 
            {
                // Get the View on Main Thread
                var appActionId = e.AppAction.Id;
                // On UI Thread Ser the Navigation for MainPage Porperty so that it will load the UI 
                // Associated with ShortCut
                var navigation =  Current.MainPage.Navigation;
                await navigation.PushModalAsync(new AppModel(e.AppAction.Title));
            });
        }
    }
}