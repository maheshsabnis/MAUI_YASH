namespace MAUI_FirstApp;

public static class MauiProgram
{
	/// <summary>
	/// Entry Point of the Application
	/// </summary>
	/// <returns></returns>
	public static MauiApp CreateMauiApp()
	{
		// Object Builder Pattern
		//1. Dependency Container
		//2. Load the APIs used for Building Appls for all Platforms
		//3. Configuration for Additional Resources e.g. Fonts  

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		

		// The Application Build ready with all Platform Features
		return builder.Build();
	}
}
