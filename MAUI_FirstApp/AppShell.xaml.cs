namespace MAUI_FirstApp;

/// <summary>
/// Shell: The Container Object for All Objects 
/// 1. XAML Objects
/// 2. Business Objects Those are directly Loaded on XAML
/// 3. All Enhanced Featutures for MAUI Apps written as enhancements e.g. Handles, Custom Controls, etc.
/// The Shell with the Lifecycle
/// </summary>
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
}
