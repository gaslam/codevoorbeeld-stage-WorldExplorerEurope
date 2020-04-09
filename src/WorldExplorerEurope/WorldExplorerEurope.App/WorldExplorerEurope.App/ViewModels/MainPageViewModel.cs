using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class MainPageViewModel : APIservice
    {
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

        public MainPageViewModel()
        {
            countries = GetCountries().Result;
        }

        public async Task<ObservableCollection<CountryVM>> GetCountries()
        {
            string responseMessage = await Get($"{WorldExplorerAPIService.BaseUrl}");
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
    }
}
