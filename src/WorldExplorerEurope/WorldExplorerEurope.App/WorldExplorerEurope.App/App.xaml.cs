using FreshMvvm;
using MediaManager;
using System;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Pages;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<IAPIinterface>(new APIservice());
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>())
            {
                BarBackgroundColor = Color.FromHex(ToolBarBackgroundcolor.backgroundColor)
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
