namespace Pugon.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("..");
        return true; // Indicate that the back button press has been handled
    }
}