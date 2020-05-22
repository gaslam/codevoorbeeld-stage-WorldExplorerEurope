using FakeItEasy;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class InfoViewModelTests
    {
        public InfoViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        private const string url = "https://localhost:5001/api/countries";

        private const string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImE1MzExMjE0LTU2NGYtNDgyNC1iYTY1LWI1NzA0MjM0OWU0OSIsInJvbGUiOiJBZG1pbiIsIm5iZiI6MTU5MDA4MzE5MywiZXhwIjoxNTkwNjg3OTkyLCJpYXQiOjE1OTAwODMxOTN9.kB_B1ILsx3Mqyb8iL3qQZglqxXXcJ_oyTBXPmcrxT2I";

        [Fact]
        public async void FavouriteCommand_returns_FavouritesListCount()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin"};
            var country = GetCountry().Result;
            infoVM.Init(country);
            int expected = infoVM.Favourites.Count + 1;
            //Act
            infoVM.AddFavouriteCommand.Execute(null);
            System.Threading.Thread.Sleep(10000);
            int actual = infoVM.Favourites.Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void WishlistCommand_returns_WishlistCount()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var country = GetCountry().Result;
            infoVM.Init(country);
            int expected = infoVM.Wishlists.Count + 1;
            //Act
            infoVM.WishlistCommand.Execute(null);
            System.Threading.Thread.Sleep(10000);
            int actual = infoVM.Wishlists.Count;
            int current = actual;
            //Assert
            Assert.Equal(expected, actual);
        }

        private async Task<Country> GetCountry()
        {
            try
            {
                using(var client = new HttpClient())
                {
                    var response = await client.GetAsync($"{url}/00000000-0000-0000-0000-000000000001");
                    if (!response.IsSuccessStatusCode) throw new Exception(await response.Content.ReadAsStringAsync());
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Country>(json);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [Fact]
        public async void Init_ValidName_returns_LengthBiggerThan0()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var actual = infoVM.CountryName.Length;
            //Assert
            Assert.True(actual > zeroLength);
        }

        [Fact]
        public async void Init_ValidDescription_returns_LengthBiggerThan0()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var actual = infoVM.Description.Length;
            //Assert
            Assert.True(actual > zeroLength);
        }

        [Fact]
        public async void Init_ValidCurrency_returns_LengthBiggerThan0()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var actual = infoVM.Currency.Length;
            //Assert
            Assert.True(actual > zeroLength);
        }

        [Fact]
        public async void Init_ValidPopulation_returns_BiggerThan0()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var noPop = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var actual = infoVM.Population;
            //Assert
            Assert.True(actual > noPop);
        }

        [Fact]
        public async void Init_ValidCapital_returns_LengthBiggerThan0()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var actual = infoVM.Capital.Length;
            //Assert
            Assert.True(actual > zeroLength);
        }

        [Fact]
        public async void Init_ValidEUMember_returns_TypeBool()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            //Act
            infoVM.Init(country);
            var member = infoVM.IsEUmember;
            //Assert
            Assert.IsType<bool>(member);
        }

        [Fact]
        public async void Init_ValidSpotifyPlaylist_returns_NotNull()
        {
            //Arrange

            var infoVM = new InfoViewModel();
            infoVM.User = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
            var zeroLength = 0;
            var country = await GetCountry();
            infoVM.Init(country);
            //Act
            var actual = infoVM.GetCountryPlaylist();
            //Assert
            Assert.NotNull(actual);
        }
    }
}
