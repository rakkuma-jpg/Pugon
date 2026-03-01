using Pugon.Pages;
using Pugon.Services;
using Pugon.ViewModel;

namespace Pugon
{
    public partial class AppShell : Shell
    {

        public AppShell(AppShellViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
            
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            Routing.RegisterRoute(nameof(RecipesPage), typeof(RecipesPage));
            Routing.RegisterRoute(nameof(BreadsPage), typeof(BreadsPage));

            Routing.RegisterRoute(nameof(ChatbotPage), typeof(ChatbotPage));
            Routing.RegisterRoute(nameof(FavoritesPage), typeof(FavoritesPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        }
    }
}
