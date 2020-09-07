using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WorldExplorerEurope.App.Pages;
using MediaManager;
using System.Net;
using System.IO;
using System.Net.Http;

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : TabbedPage
    {
        private InfoViewModel _infoViewModel;
        public InfoPage(Country country)
        {
            InitializeComponent();
            this.HeightRequest = 600;
            this.BarBackgroundColor = Color.FromHex("#fe5f55");
        }

        private async void lsvSpotify_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}