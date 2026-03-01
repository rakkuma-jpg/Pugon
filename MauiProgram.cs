using Microsoft.Extensions.Logging;
using Pugon.Pages;
using Pugon.Services;
using Pugon.ViewModel;

namespace Pugon
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<AppShell>();

            builder.Services.AddTransient<RecipesPage>();
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<ProfilePage>();

            return builder.Build();
        }
    }
}
