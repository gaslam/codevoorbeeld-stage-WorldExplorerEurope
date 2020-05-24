using AutoMapper;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using Syncfusion.DataSource.Extensions;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Test.Services;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class LoginViewModelTests : IClassFixture<WorldExplorerAPIFactory<Startup>>
    {
        private const string url = "https://localhost:5001/api/countries/users";
        private const string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImE1MzExMjE0LTU2NGYtNDgyNC1iYTY1LWI1NzA0MjM0OWU0OSIsInJvbGUiOiJBZG1pbiIsIm5iZiI6MTU5MDA4MzE5MywiZXhwIjoxNTkwNjg3OTkyLCJpYXQiOjE1OTAwODMxOTN9.kB_B1ILsx3Mqyb8iL3qQZglqxXXcJ_oyTBXPmcrxT2I";
        private HttpClient _client;
        private readonly WorldExplorerAPIFactory<Startup> _factory;


        //Used to mock the platform
        public LoginViewModelTests(WorldExplorerAPIFactory<Startup> factory)
        {
            _factory = factory;

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
        public async void LoginCommand_returns_NoErrorMessage()
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();
                loginViewModel.Init(moq.Object);
                loginViewModel.test = true;
                loginViewModel.newUser = new UserLogin() { Email = "test2.test2@student.howest.be", Password = "9xE6ALJfQ6$k" };
                //Act
                var response = await GetUser(new UserLoginDto() { Email = loginViewModel.newUser.Email, Password = loginViewModel.newUser.Password });
                if (!response.IsSuccessStatusCode) loginViewModel.newUser.ErrorMessage = await response.Content.ReadAsStringAsync();

                //Assert
                Assert.Null(loginViewModel.newUser.ErrorMessage);

            }
            catch(Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]
        public async void LoginCommand_returns_UserLogin()
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();
                loginViewModel.Init(moq.Object);
                loginViewModel.test = true;

                //Act

                loginViewModel.newUser = new UserLogin() { Email = "test2.test2@student.howest.be", Password = "9xE6ALJfQ6$k" };

                //Assert
                Assert.IsType<UserLogin>(loginViewModel.newUser);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        private async Task<HttpResponseMessage> GetUser(UserLoginDto user)
        {
            try
            {
                using (var client = _client)
                {
                    var json = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync($"{url}/login", content);
                    return response;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [Fact]
        public void Init_returns_UserLogin()
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();

                //Act
                loginViewModel.Init(moq.Object);
                loginViewModel.test = true;

                //Assert
                Assert.IsType<UserLogin>(loginViewModel.newUser);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Theory]
        //InValid emails
        [InlineData("gaspard.lammertynstudent.howest.be", "t}F87)8GBaj<", "Email")]
        [InlineData(null, "t}F87)8GBaj<", "Email")]
        //Invalid passwords
        [InlineData("gaspard.lammertyn@student.howest.be", null, "Password")]
        [InlineData("gaspard.lammertyn@student.howest.be", "", "Password")]
        public void GetErrors_ValidatesUser_returns_true(string mail, string password, string property)
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();
                loginViewModel.Init(moq.Object);
                loginViewModel.DataForm.ValidationMode = ValidationMode.PropertyChanged;
                loginViewModel.newUser = new UserLogin() { Email = mail, Password = password };

                bool expected = true;
                //Act
                var errors = loginViewModel.newUser.GetErrors(property).ToList<string>();
                var actual = errors.Any<string>(m => m.Contains(property.ToLower()));

                //Assert
                Assert.Equal(expected, actual);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }
    }
}
