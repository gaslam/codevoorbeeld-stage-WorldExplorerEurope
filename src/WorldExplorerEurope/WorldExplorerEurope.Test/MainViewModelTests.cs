using FakeItEasy;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.Test.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class MainViewModelTests : IClassFixture<WorldExplorerAPIFactory<Startup>>
    {
        private const string url = "https://localhost:5001/api/countries";

        private readonly WorldExplorerAPIFactory<Startup> _factory;
        private HttpClient _client;
        private IAPIinterface aPIinterface;
        public MainViewModelTests(WorldExplorerAPIFactory<Startup> factory)
        {
            _factory = factory;

            var scope = factory.Services.CreateScope();
            WebApplicationFactoryClientOptions options = new WebApplicationFactoryClientOptions();
            options.MaxAutomaticRedirections = 1000;
            options.HandleCookies = false;
            _client = _factory.CreateClient(options);

            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public async void GetCountries_returns_NotNullList()
        {
            //Arrange
            var mainViewModel = new MainViewModel(aPIinterface);

            //Act

            var countries = await Countries();
            mainViewModel.Countries = countries;

            //Assert
            Assert.NotNull(mainViewModel.Countries);
        }

        [Fact]
        public async void Filter_returns_NotNull()
        {
            //Arrange
            var mainViewModel = new MainViewModel(aPIinterface);
            var countries = await Countries();
            mainViewModel.Countries = countries;

            //Act
            var actual = mainViewModel.Filter("Hamburger");

            //Assert
            Assert.NotNull(actual);
        }

        [Fact]
        public async void LocationCommand_returns_Location()
        {
            //Arrange
            var openCageService = new OpenCageService();
            double lng = 4.125298;
            double lat = 50.882540;
            string expected = "Belgium";

            var countries = await Countries();

            //Act
            var actual = await openCageService.GetCountry(lng, lat, countries);

            //Assert
            Assert.Equal(expected, actual.Name);
        }

        private async Task<ObservableCollection<Country>> Countries()
        {
            try
            {
                using (var client = _client)
                {
                    var response = await client.GetAsync($"{url}");
                    if (!response.IsSuccessStatusCode) throw new Exception(await response.Content.ReadAsStringAsync());
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ObservableCollection<Country>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
