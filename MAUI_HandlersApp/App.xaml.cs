using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;

namespace MAUI_HandlersApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            // Using the Entry Handler from Entry Class to ikts Derived class

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler,view) => 
            {
                if (view is Entry)
                {
#if ANDROID
                    handler.PlatformView.SetBackgroundColor(Colors.Cyan.ToPlatform());
                    
#elif IOS
                    handler.PlatformView.BackgroundColor = Colors.Red.ToPlatform();
#elif WINDOWS
                    handler.PlatformView.Background = Colors.Magenta.ToPlatform();
#endif
                }

            });

            Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping<IButton, IButtonHandler>(nameof(IView.Background), (handler, view) => 
            {
#if ANDROID
                    handler.PlatformView.SetBackgroundColor(Colors.Yellow.ToPlatform());
#elif IOS
                    handler.PlatformView.BackgroundColor = Colors.Red.ToPlatform();
#elif WINDOWS
                    handler.PlatformView.Background = Colors.Magenta.ToPlatform();
#endif

            });
        }
    }
}