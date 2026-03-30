using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Pugon.Pages;
using Pugon.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pugon.ViewModel
{
    public partial class AppShellViewModel : ObservableObject
    {
        private readonly AuthService _authService;
        public AppShellViewModel(AuthService authService)
        {
            _authService = authService;
        }
        [RelayCommand]
        async Task SignOut()
        {
            // Implement sign-out logic here (e.g., clear user data, navigate to login page)
            _authService.Logout();
            await Shell.Current.GoToAsync($"//{nameof(Pages.LoginPage)}");
        }
        [RelayCommand]
        async Task NavigateToSettings() {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }

    }
}
