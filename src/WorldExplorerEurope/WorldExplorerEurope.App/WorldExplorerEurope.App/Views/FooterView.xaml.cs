using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FooterView : ContentView
    {
        public FooterView()
        {
            InitializeComponent();
            CheckUser();
        }

        private void CheckUser()
        {
            LocalService localService = new LocalService();
            var user = localService.GetUser();
            imgGesture1.Command = MainCommand;
            lblGesture1.Command = MainCommand;
            if(user!= null)
            {
                lblUser.Text = "MyCountries";
                imgGesture2.Command = MyCountryCommand;
                lblGesture2.Command = MyCountryCommand;
            }
            else
            {
                imgGesture2.Command = LoginCommand;
                lblGesture2.Command = LoginCommand;
            }
        }

        public ICommand LoginCommand => new Command(
            async () =>
            {
                App.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginViewModel>());
            });
        public ICommand MainCommand => new Command(
            async () =>
            {
                App.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>())
                {
                    BarBackgroundColor = Color.FromHex(ToolBarBackgroundcolor.backgroundColor)
                };
            });


        public ICommand MyCountryCommand => new Command(
            async () =>
            {
                App.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MyCountriesViewModel>())
                {
                    BarBackgroundColor = Color.FromHex(ToolBarBackgroundcolor.backgroundColor)
                };
            });

    }
}