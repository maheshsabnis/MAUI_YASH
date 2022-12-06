# MAUI Apps

1. Application Development
	- Databinding
	- MVVM
		- Use the Property Changed Notification on ViewModel class to Notify Data Update to View

		- To Listen event raised on UI, the ViewModel must use 'Commanding' aka 'Commands'
		- Action and Action<T> Delegates
			- They are used to Invoke a method that has no return type
			- T is the method that has input Parameter as type T
		- The ICommand interface
			- System.Windows.Input
				- CanExecute(), return bool
				- Execute(), Invoke the method using delegate
		- ViewModel
			- Public Properties for Read/Write Operations
			- One Way Methods, these will be executed based on Event (aka Command) Dispatched from UI
			- Command Object, To Listen an event raised or dispatched from View and Handle it
		- CommunityToolkit.Mvvm
	- REST API Calls
		
	- Dependency Injection
	- Navigation
		- Routing.ResgisterRoute("URL", ViewTypeName)
		- Use the Shell.Current,.GoToAsync("URL", Navigation Parameters as a Dictionary)
		- On Receiver Page, implement the IQueryAttributable interface 
			- ApplyQueryAttributes(IDictionary<string, object> query) method
				- string: The Route Parameter Name
				- Object the Value of the Parameter
			- Read the Value using Following Expression
				- var value = query["PARAMETER-NAME"];
2. Mobile Application Development Features
	- Permissions
	- Essentials
		- AppActions
		- Storage
		- Preferences
	- Mobile App Programming
		- Contacts
		- Email
		- SMS
3. MAUI Specific Features
	- MainThread
	- Handlers
	- Custom Controls
	- Performance
4. Publishing