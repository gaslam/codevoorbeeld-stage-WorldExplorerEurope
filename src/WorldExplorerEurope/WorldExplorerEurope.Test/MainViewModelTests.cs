using FakeItEasy;
using Microsoft.Extensions.DependencyInjection;
using System;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class MainViewModelTests
    {
        private const string url = "https://localhost:5001/api/countries";

        public MainViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public async void GetCountries_returns_NotNullList()
        {
            //Arrange
            var mainViewModel = new MainViewModel();

            //Act

            var countries = await mainViewModel.GetCountries();

            //Assert
            Assert.NotNull(countries);
        }

        [Fact]
        public async void Filter_returns_NotNull()
        {
            //Arrange
            var mainViewModel = new MainViewModel();
            await mainViewModel.GetCountries();

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

            //Act
            var actual = await openCageService.GetCountry(lng, lat);

            //Assert
            Assert.Equal(expected, actual.Name);
        }
    }
}
