namespace MAUI_AppActions
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureEssentials(essentials => 
                {
                    essentials.AddAppAction(new AppAction("actmessage","My Message",icon:"messages"));
                    essentials.AddAppAction(new AppAction("actcalender", "My Appointements", icon: "calender"));
                    essentials.AddAppAction(new AppAction("actinfo", "App Information", icon: "appinfo"));
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }
    }
}