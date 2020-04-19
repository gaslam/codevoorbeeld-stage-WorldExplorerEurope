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

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        private InfoViewModel _infoViewModel;
        public InfoPage(Country country)
        {
            InitializeComponent();
            this.HeightRequest = 600;
        }
    }
}