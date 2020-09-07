using FakeItEasy;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using Newtonsoft.Json;
using Syncfusion.DataSource.Extensions;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Test.Services;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class RegisterViewModelTests : IClassFixture<WorldExplorerAPIFactory<Startup>>
    {
        private const string url = "https://localhost:5001/api/countries/Users";
        private HttpClient _client;
        private readonly WorldExplorerAPIFactory<Startup> _factory;

        private readonly IAPIinterface apiService;


        //Used to mock the platform
        public RegisterViewModelTests(WorldExplorerAPIFactory<Startup> factory)
        {
            _factory = factory;
            WebApplicationFactoryClientOptions options = new WebApplicationFactoryClientOptions();
            options.MaxAutomaticRedirections = 1000;
            options.HandleCookies = false;
            _client = _factory.CreateClient(options);

            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public async void RegisterCommand_returns_NoErrorMessage()
        {
            //Arrange
            try
            {
                var moq = new Mock<IAPIinterface>();
                var register = new RegisterViewModel(moq.Object);
                register.test = true;
                register.Init(moq.Object);
                register.newUser = new UserRegister() { FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test12345.test123@test.howest.be", Password = "t}F87)8GBaj<"  };
                //Act
                var response = await GetUser(register.newUser);

                if (!response.IsSuccessStatusCode) register.newUser.ErrorMessage = await response.Content.ReadAsStringAsync();

                //Assert
                Assert.Null(register.newUser.ErrorMessage);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]
        public void RegisterCommand_returns_UserRegister()
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var register = new RegisterViewModel(moq.Object);

            //Act
            register.Init(moq.Object);

            while (register.test == true)
            {

            }

            //Assert
            Assert.IsType<UserRegister>(register.newUser);
        }

        private async Task<HttpResponseMessage> GetUser(UserRegister userRegister)
        {
            try
            {
                using (var client = _client)
                {
                    var user = new UserDto { FirstName = userRegister.FirstName, LastName = userRegister.LastName, BirthDate = userRegister.BirthDate.Date, Nationality = userRegister.Nationality, Email = userRegister.Email, Password = userRegister.Password, Role="Visitor", IsSpotifyDj = false };
                    var json = JsonConvert.SerializeObject(user);
                    StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync($"{url}/register", stringContent);
                    return response;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static IEnumerable<object[]> RegisterData()
        {
            //Invalid FirstNames
            yield return new object[] { "", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "FirstName" };
            yield return new object[] { null, "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "FirstName" };
            //Invalid LastNames
            yield return new object[] { "test", "", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "LastName" };
            yield return new object[] { "test", null, DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "LastName" };
            //Invalid BirthDates
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-8).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "BirthDate" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "BirthDate" };
            //Invalid Nationalities
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "Nationality" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, null, "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "Nationality" };
            //Invalid emails
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "test.studenthowest.be", "t}F87)8GBaj<", "t}F87)8GBaj<", "Email" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", null, "t}F87)8GBaj<", "t}F87)8GBaj<", "Email" };
            //Invalid Passwords
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", null, "t}F87)8GBaj<", "Password" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "", "t}F87)8GBaj<", "Password" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F88Baj<", "t}F87)8GBaj<", "Password" };
            //Invalid Repeated Passwords
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "", "PasswordRepeat" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", null, "PasswordRepeat" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "", "t}F87)8GBaj<", "PasswordRepeat" };
        }


        [Theory]
        [MemberData(nameof(RegisterData))]
        public void GetErrors_ValidatesUser_returns_true(string firstname, string lastname, DateTime dateOfBirth, string nationality, string mail, string password, string passwordRepeat, string property)
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var loginViewModel = new RegisterViewModel(moq.Object);
            loginViewModel.Init(moq.Object);
            loginViewModel.newUser = new UserRegister() { FirstName = firstname, LastName = lastname, Nationality = nationality, Email = mail, Password = password, PasswordRepeat = passwordRepeat };
            loginViewModel.newUser.BirthDate = dateOfBirth;

            bool expected = true;
            //Act
            var errors = loginViewModel.newUser.GetErrors(property).ToList<string>();
            var actual = errors.Any();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
