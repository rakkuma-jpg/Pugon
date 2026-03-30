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

            Routing.RegisterRoute(nameof(SignUp_IdentityPage), typeof(SignUp_IdentityPage));
            Routing.RegisterRoute(nameof(SignUp_CredentialsPage), typeof(SignUp_CredentialsPage));
            Routing.RegisterRoute("breadspage", typeof(BreadsPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

        }
    }
}
