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
		- System.Net.Http.Json namespace
			- .NET 5+
				- HttpClient with Extension Methods
				- GetFromJsonAsync<T>(URL);
					- T is the Type of Response Received from Service
				- PostAsJsonAsync<T>(URL, T)
					- T is the Data to be posted
				- PutAsJsonAsync<T>(URL, T);
				- DeleteAsJsonAsync<T>(URL);
		- REST API MUST be Secure**
			- JSON Web Token for Security
		- MAUI Perspective of Security
			- Custom Token BAsed Security
			- Using an Idneitty Providers
				- Microsoft, Google, Facebook, etc.
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
			- Microsoft.Maui.Storage namespace
				- ISecureStorage Interface
					- Kay/Value Pair
				- SecureStorage.Default
					- SetAsync(Key,Value)
					- value = GetAsync(Key)
			- For iOS Emulator
				- permission list file aka plist file
```` xml
<plist version="1.0">
	<dict>
		<key>keychan-aceess-group</key>
		<array>
			<string>${AppIdentifierPrefixes}se.hindreikes</string>
		</array>
	</dict>
</plist>
````
			- for Android EMultaor
```` xml
<?xml version="1.0" encoding="utf-8" ?>
<full-backup-content>
	<!--The COnfiguration will make sure that the contents of Secure Storage are available across all Application-->
	<include domain="sharedpref" path="."/>
	<include domain="sharedpref" path="${applicationId}.mauiessentials.xml"/>
</full-backup-content>
````
		- Preferences
			- Secure Storage is accessible by the Multiple Applciation  and the Information in Preferences is stored in the Application's OWN Cache
			- Extremly IMP Part
				- Secure Stoarge is not removed with App uninstallation
			- Microsoft.Maui.Storage namespace
				- IPreferences 
				- Preferences.Default
					- String, Boolean, Int32, Double, Single, Int64, 
					- DateTime
						- 64-bit Binary aka long integer
							- Save: Using ToBinary()
							- Read: FromBinary()
				- Methods
					- Set("KEY", Value)
					- Get("KEY", DEFAULT_VALUE)
						- DEFAULT_VALUE
							- Baserd on Type of Data Stored in Preferences
						- For String on Platform as "Windows Machine", the 'string.empty' as default is allowed
							- Preferences.Default.Get("MY_KEY", null OR String.Empty)
								- On Windows Machine the value will be either null or empty
						- For Device
							- the null will be "null" means the value will be "null" string
					- ContainsKey("KEY")
						- Return Bool
					- Remove("KEY")
						- Remove a single Key
					- Clear()
						- Clear or Remove all Keys
				- Andrioid
					- Uses the "Shared Preferences"
				- Windows MAchine
					- ApplicationDataContainer
				- iOS and macOS
					- NSUserDefaults
				- If the Custom CLR Object to be stored in Preferences
					- Person Object, 
						- Serialize it in JSON form and store it in Preference
						- Retrived it from Preferencesa at application Load and use it
			
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