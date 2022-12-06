using MAUI_MVVM.Models;
using MAUI_MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MAUI_MVVM
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register the Object in Dependency Container
            builder.Services.AddSingleton<ExpensesLogic>();
            // Make sure that All Objects used in Chain e.g. from Model to View MUST be
            // Registered in DI Container
            builder.Services.AddSingleton<ExpensesViewModel>();
            // Register the MainPage Type So that all od its depdendencies will be resolved
            // and injected (Make sure that the View Type Classes MUST be registered at the end in DI Container)

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}