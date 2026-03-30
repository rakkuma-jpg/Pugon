using Microsoft.Extensions.DependencyInjection;

namespace Pugon
{
    public partial class App : Application
    {
        
        public static string ImageServerPath { get; } = "https://raw.githubusercontent.com/rakkuma-jpg/virtual_storage/main/images/";
        private readonly AppShell _appShell;
        public App(AppShell appShell)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JHaF5cWWdCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdlWXxfdnRdRWRZUUF/W0VWYEo=");
            InitializeComponent();
            _appShell = appShell;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(_appShell);
        }
    }
}