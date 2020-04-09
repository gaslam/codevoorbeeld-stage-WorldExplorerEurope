using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            mainPageViewModel = new MainPageViewModel();
            InitializeComponent();
            SfListViewCountries.ItemsSource = mainPageViewModel.Countries;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        private void OnFilterChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = sender as SearchBar;
            if(SfListViewCountries.DataSource != null && searchBar.Text != null)
                SfListViewCountries.ItemsSource = mainPageViewModel.Countries.Where(m => m.Name.ToLower().Contains(searchBar.Text.ToLower()));
            else
                SfListViewCountries.ItemsSource = mainPageViewModel.Countries;

        }
    }
}
