namespace Pugon.Pages;

public partial class SignUp_CredentialsPage : ContentPage
{
	public SignUp_CredentialsPage()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed() 
    {
        Shell.Current.GoToAsync("..");
        return true; // Indicate that the back button press has been handled
    }
    private async void Label_LogIn_Clicked(object sender, EventArgs e)
    {
        // Navigate back to the log-in page when the button is clicked
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
    private async void Button_Next_Clicked(object sender, EventArgs e)
    {
        // Navigate to SignUp_CredentialsPage when the button is clicked
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}