using FakeItEasy;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.Test.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class MyCountriesViewModelTests : IClassFixture<WorldExplorerAPIFactory<Startup>>
    {

        private const string url = "https://localhost:5001/api/countries";
        private HttpClient _client;
        private readonly WorldExplorerAPIFactory<Startup> _factory;

        public MyCountriesViewModelTests(WorldExplorerAPIFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();

            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        private async void WishlistsCommand_NewWishlist_returns_NotNull()
        {
            //Arrange
            var user = new User()
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                FirstName = "test",
                LastName = "test",
                BirthDate = Convert.ToDateTime("12/05/1998"),
                Email = "test.test@student.howest.be",
                Nationality = "Belgium",
                Role = "Admin"
            };

            var moq = new Mock<MyCountriesViewModel>();
            var myCountriesVM = new MyCountriesViewModel();
            myCountriesVM.test = true;
            myCountriesVM.User = user;

            //Act
            myCountriesVM.Init(moq.Object);
            myCountriesVM.countryList = await Countries();
            myCountriesVM.WishlistsCommand.Execute(null);

            //Assert
            Assert.NotNull(myCountriesVM.Countries);

        }

        [Fact]
        private async void WishlistsCommand_NewWishlist_returns_ObservableCollection()
        {
            //Arrange
            var user = new User()
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                FirstName = "test",
                LastName = "test",
                BirthDate = Convert.ToDateTime("12/05/1998"),
                Email = "test.test@student.howest.be",
                Nationality = "Belgium",
                Role = "Admin"
            };

            var moq = new Mock<MyCountriesViewModel>();
            var myCountriesVM = new MyCountriesViewModel();
            myCountriesVM.User = user;
            myCountriesVM.test = true;

            //Act
            myCountriesVM.Init(moq.Object);
            myCountriesVM.countryList = await Countries();
            myCountriesVM.WishlistsCommand.Execute(null);

            //Assert
            Assert.IsType<ObservableCollection<Country>>(myCountriesVM.Countries);

        }

        [Fact]
        private async void FavouritesCommand_NewWishlist_returns_NotNull()
        {
            //Arrange
            var user = new User()
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                FirstName = "test",
                LastName = "test",
                BirthDate = Convert.ToDateTime("12/05/1998"),
                Email = "test.test@student.howest.be",
                Nationality = "Belgium",
                Role = "Admin"
            };

            var moq = new Mock<MyCountriesViewModel>();
            var myCountriesVM = new MyCountriesViewModel();
            myCountriesVM.User = user;
            myCountriesVM.test = true;

            //Act
            myCountriesVM.Init(moq.Object);
            myCountriesVM.countryList = await Countries();
            myCountriesVM.FavouritesCommand.Execute(null);

            //Assert
            Assert.NotNull(myCountriesVM.Countries);

        }

        [Fact]
        private async void FavouritesCommand_NewWishlist_returns_ObservableCollection()
        {
            //Arrange
            var user = new User()
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                FirstName = "test",
                LastName = "test",
                BirthDate = Convert.ToDateTime("12/05/1998"),
                Email = "test.test@student.howest.be",
                Nationality = "Belgium",
                Role = "Admin"
            };

            var moq = new Mock<MyCountriesViewModel>();
            var myCountriesVM = new MyCountriesViewModel();
            myCountriesVM.User = user;
            myCountriesVM.test = true;

            //Act
            myCountriesVM.Init(moq.Object);
            myCountriesVM.countryList = await Countries();
            myCountriesVM.FavouritesCommand.Execute(null);

            //Assert
            Assert.IsType<ObservableCollection<Country>>(myCountriesVM.Countries);

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
