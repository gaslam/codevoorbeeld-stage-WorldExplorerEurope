using FreshMvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.App.Views;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class MainViewModel : FreshBasePageModel, INotifyPropertyChanged
    {

        private IAPIinterface _apiService;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            _apiService = new APIservice();
            countries = GetCountries().Result;
            ActivityIndicator = new bool();
            ActivityIndicator = false;
        }

        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get
            {
                return countries;
            }
            set
            {
                this.countries = value;
            }
        }

        public async Task<ObservableCollection<Country>> GetCountries()
        {
            try
            {
                LocalService localService = new LocalService();
                 var countries = await localService.GetCountriesAsync();
                return countries;
            }
            catch
            {
                return null;
            }

        }

        private static Country selectedCountry;

        public void setSelectedCountry(Country country)
        {
            selectedCountry = country;
        }

        public Country GetCountry()
        {
            return selectedCountry;
        }

        private bool activityIndicator;
        public bool ActivityIndicator
        {
            get { return activityIndicator; }
            set
            {
                this.activityIndicator = value;
                ChangeProperty(nameof(ActivityIndicator));
            }
        }

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public ICommand LoginCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<LoginViewModel>(null, false, true);
            });
        public ICommand ItemTappedCommand => new Command(
            async () =>
            {
                ActivityIndicator = true;
                await CoreMethods.PushPageModel<InfoViewModel>(selectedCountry, false, true);
                ActivityIndicator = false;
            });

        public List<Country> Filter(string country)
        {
            return countries.Where(m => m.Name.ToLower().Contains(country.ToLower())).ToList();
        }

        public ICommand LocationCommand => new Command(
            async () =>
            {
                try
                {
                    ActivityIndicator = true;
                    LocationService locationService = new LocationService();
                    var location = await locationService.GetLocation();
                    if (location == null) throw new Exception();
                    setSelectedCountry(location);
                    await CoreMethods.PushPageModel<InfoViewModel>(selectedCountry, false, true);
                    ActivityIndicator = false;
                }
                catch
                {
                    ActivityIndicator = false;
                    await App.Current.MainPage.DisplayAlert("Error", "Cannot get your location.", "Ok");
                }
            });
    }
}
