using Pugon.Services;

namespace Pugon.Pages;

public partial class LoginPage : ContentPage
{
	private readonly AuthService _authService;
    public LoginPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;

	}
	private async void Button_Clicked(object sender, EventArgs e)
	{
		_authService.Login();
		// Navigate to the home page when the button is clicked
		await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}