using Pugon.ViewModel;

namespace Pugon.Pages;

public partial class RecipesPage : ContentPage
{
	public RecipesPage()
	{
		InitializeComponent();
        BindingContext = new RecipesViewModel();
    }
}