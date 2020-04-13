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
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {

        private IAPIinterface _apiService;

        public MainViewModel()
        {
            _apiService = new APIservice();
            countries = GetCountries().Result;
        }

        private ObservableCollection<CountryVM> countries;
        public ObservableCollection<CountryVM> Countries
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

        public async Task<ObservableCollection<CountryVM>> GetCountries()
        {
            string responseMessage = await _apiService.Get($"{WorldExplorerAPIService.BaseUrl}");
            ObservableCollection<CountryVM> countryVMs = new ObservableCollection<CountryVM>();
            var countries = JsonConvert.DeserializeObject<List<Country>>(responseMessage);
            foreach (var country in countries)
            {
                countryVMs.Add(new CountryVM
                {
                    Name = country.Name,
                    Flag = country.FlagUrl
                });
            }
            return countryVMs;

        }

        public ICommand LoginCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<LoginViewModel>(null,true ,true);
            });
    }
}
