namespace MAUI_AppActions;

public partial class AppModel : ContentPage
{
	public AppModel(string pageTitle)
	{
		InitializeComponent();

		lbl.Text = $"Hay!! You Have  Requested to Open the {pageTitle} acc action";
	}
}