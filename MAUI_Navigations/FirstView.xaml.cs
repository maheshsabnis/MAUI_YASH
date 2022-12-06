using System.Text.Json;

namespace MAUI_Navigations;

public partial class FirstView : ContentPage, IQueryAttributable
{
	public FirstView()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
         // Read Value of Route Parameter

        var contact = query["Contact"] as ContactDetail; 

        lblContact.Text = JsonSerializer.Serialize (contact); ;

    }
}