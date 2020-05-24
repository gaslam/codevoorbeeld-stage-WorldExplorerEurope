using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Pages;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.Pages
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel mainPageViewModel;
        public MainPage()
        {
            mainPageViewModel = new MainViewModel();
            InitializeComponent();
            SfListViewCountries.ItemsSource = mainPageViewModel.Countries;
        }

        private void OnFilterChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = sender as SearchBar;
            if (SfListViewCountries.DataSource != null && searchBar.Text != null)
                SfListViewCountries.ItemsSource = mainPageViewModel.Filter(searchBar.Text);
            else
                SfListViewCountries.ItemsSource = mainPageViewModel.Countries;

        }

        private async void SfListViewCountries_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            mainPageViewModel.setSelectedCountry(e.ItemData as Country);
        }
    }
}
