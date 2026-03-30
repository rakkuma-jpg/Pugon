using Microsoft.Extensions.Logging;
using Pugon.Pages;
using Pugon.Services;
using Pugon.ViewModel;
using CommunityToolkit.Maui;
using Syncfusion.Maui.Core.Hosting;

namespace Pugon
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("canva-sans-regular.otf", "CanvaSansRegular");
                    fonts.AddFont("Inter-VariableFont.ttf", "InterVariable");
                });
                

#if DEBUG
    		builder.Logging.AddDebug();
#endif 
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<AppShell>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<SignUp_IdentityPage>();
            builder.Services.AddTransient<SignUp_CredentialsPage>();
            builder.Services.AddTransient<RecipesPage>();
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<SettingsPage>();

            return builder.Build();
        }
    }
}
