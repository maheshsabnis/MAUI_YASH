# Day 2: 06-Dec-2022
1. Modify the MAUI_MVVM Application by adding two Views  as follows
	- ExpensesList: This will Show all Expenses in List
	- ExpensesDetails: This will allow End User to Register new Expense
2. When the Application Loads the ExpensesList View MUST be displayed, thsi view will have a button that will navigate to ExpensesDetails view to Register new Expense

HINT: Use the CommunityToolKit.Mvvm usiew the [QueryPropertyAttribute] class as attribute class on ViewModel to Read the Route Parameter

# Day 3: 07-Dec-2022
Take the Token Secure API from the Following LInk
https://www.webnethelper.com/2021/08/aspnet-core-5-and-blazor-web-assembly.html

1. Create a RegisterUser.xaml and LoginUser.Xaml, once the Login is Successful, get the token from the API and Save it in SecureStorage. Create DataAccess.xaml page with 'Get Data' button on it. When this button is clicked, retfrieve the Token from Secure Storage and pass it to the REST API to access the data based on the validation of the Token
	- HttpClient client = new HttpClient()
	- client.DefaultRequestHeaders.Add("AUTHORIZATION", $"Bearer {TOKEN_RETRIEVED_FROM-SECURE_STORAGE}");
	- client.GetFromJsonAsync("URL")
2. Create  MAUI App that will be having the Following Feature
	- This will have a View that will allow the user to enter the personal information using the following class
		- Class PersonalInfo
			- FullName
			- MobileNo
			- EmailAddress
			- AgeGroup
				- >=18 is 'CanVote'
				- else 'Minor'
		- This information must be stored in Preferences
		- Once the Application is loaded the based on the AgeGroup value the 'CanVote' view will be enable so display for the current user
