using CommunityToolkit.Maui.Extensions;
using Pugon.PopupPage;
namespace Pugon.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
	private void OnCounterClicked(object? sender, EventArgs e)
	{
        MauiPopup.PopupAction.DisplayPopup(new PopupBreadDetailsPage());
    }
}