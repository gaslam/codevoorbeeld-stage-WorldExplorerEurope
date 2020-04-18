using FreshMvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {

        private IAPIinterface _apiService;

        public MainViewModel()
        {
            _apiService = new APIservice();
            countries = GetCountries().Result;
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

        public static Country selectedCountry;

        public void setSelectedCountry(Country country)
        {
            selectedCountry = country;
        }

        public Country GetCountry()
        {
            return selectedCountry;
        }

        public ICommand LoginCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<LoginViewModel>(null, false, true);
            });
        public ICommand ItemTappedCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<InfoViewModel>(selectedCountry, false, true);
            });
        public ICommand LocationCommand => new Command(
            async () =>
            {
                try
                {
                    LocationService locationService = new LocationService();
                    var location = await locationService.GetLocation();
                    if (location == null) throw new Exception();
                    setSelectedCountry(location);
                    await CoreMethods.PushPageModel<InfoViewModel>(selectedCountry, false, true);
                }
                catch
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Cannot get your location.", "Ok");
                }
            });
    }
}
