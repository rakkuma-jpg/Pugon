using Pugon.Services;

namespace Pugon.Pages;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authservice;
    public LoadingPage(AuthService authService)
	{
		InitializeComponent();
		_authservice = authService;
	}
	protected async override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		if (await _authservice.IsAuthenticatedAsync())
		{
            //user is logged in, navigate to home page
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
		}
		else
		{
            //user is not logged in, navigate to login page
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
		}
    }
}