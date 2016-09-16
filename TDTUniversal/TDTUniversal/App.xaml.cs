using Windows.UI.Xaml;
using System.Threading.Tasks;
using TDTUniversal.Services.SettingsServices;
using Windows.ApplicationModel.Activation;
using Template10.Controls;
using Template10.Common;
using System;
using System.Linq;
using Windows.UI.Xaml.Data;
using TDTUniversal.API.Requests;
using TDTUniversal.API;
using System.Diagnostics;
using System.Text;
using System.Net.Http;
using System.Net;
using TDTUniversal.API.Respond;
using TDTUniversal.Services;

namespace TDTUniversal
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                SettingsService.Instance.User = "51403318";
                SettingsService.Instance.Password = "51403318TDT";
                var sv = await TokenService.Instance.TokenProvider.GetTokenAsync();
                await Task.Yield();
            });


            SplashFactory = (e) => new Views.Splash(e);

            #region App settings

            var _settings = SettingsService.Instance;
            RequestedTheme = _settings.AppTheme;
            CacheMaxDuration = _settings.CacheMaxDuration;
            ShowShellBackButton = _settings.UseShellBackButton;


            #endregion
        }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            if (Window.Current.Content as ModalDialog == null)
            {
                // create a new frame 
                var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);

                // create modal root
                Window.Current.Content = new ModalDialog
                {
                    DisableBackButtonWhenModal = true,
                    Content = new Views.Shell(nav),
                    ModalContent = new Views.Busy(),
                };
            }
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            // long-running startup tasks go here
            // await Task.Delay(5000);

            NavigationService.Navigate(typeof(Views.LoginPage));
            await Task.CompletedTask;
        }
    }
}

