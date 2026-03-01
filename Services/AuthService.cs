using System;
using System.Collections.Generic;
using System.Text;

namespace Pugon.Services
{
    public class AuthService
    {
        private const string AuthStateKey = "AuthState";
        public async Task<bool> IsAuthenticatedAsync()
        {
            // Simulate an authentication check (replace with real logic)
            await Task.Delay(2000); // Simulate network delay

            var AuthState = Preferences.Default.Get<bool>(AuthStateKey, false);

            return AuthState; // Assume the user is authenticated for this example
        }
        public void Login()
        { 
            Preferences.Default.Set<bool>("AuthState", true);
        }
        public void Logout()
        {
            Preferences.Default.Remove(AuthStateKey);
        }
    }
}
