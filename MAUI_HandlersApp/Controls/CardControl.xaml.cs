namespace MAUI_HandlersApp.Controls;

public partial class CardControl : ContentView
{
    // For Step 1. Create a bindable property using which the Control will aceept the data from parent and release it to its parent

    //public BindableProperty TitleProperty = 
    //    BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl), propertyChanged: (bindable, oldValue, newValue) => 
    //	{
    //		// Update the control when the data is bound with it
    //		var control = (CardControl)bindable;
    //		control.TitleLabel.Text = newValue as string; 	 
    //	});

    // For Step 2 For using Control Template in Template Bindign
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl));


    public CardControl()
	{
		InitializeComponent();
	}

	// 2. Create a Read/Write Property that will be used for Actual Databinding
	// This will use the Bindable property as a 'backing-store' (aka the memory where the data will be saved) 

	public string Title 
	{
		get=> GetValue(TitleProperty) as string; 
		set=> SetValue(TitleProperty, value); 
	}
}