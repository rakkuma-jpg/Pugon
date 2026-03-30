using Pugon.Services;

namespace Pugon.Pages;

public partial class SignUp_IdentityPage : ContentPage
{
	public SignUp_IdentityPage()
	{
		InitializeComponent();
	}
    private async void Button_Next_Clicked(object sender, EventArgs e)
    {
        // Navigate to SignUp_CredentialsPage when the button is clicked
        await Shell.Current.GoToAsync(nameof(SignUp_CredentialsPage));
    }
    private async void Label_LogIn_Clicked(object sender, EventArgs e)
    {
        // Navigate back to the log-in page when the button is clicked
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("..");
        return true; // Indicate that the back button press has been handled
    }
}