﻿using FakeItEasy;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Newtonsoft.Json;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Helpers;
using WorldExplorerEurope.API.Domain.Interfaces;
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
    public class EditViewModelTests : IClassFixture<WorldExplorerAPIFactory<Startup>>
    {

        private const string url = "https://localhost:5001/api/countries";
        private protected string token = "";

        private HttpClient _client;
        private readonly WorldExplorerAPIFactory<Startup> _factory;

        private Mock moqApiService;
        private User user;

        //Used to mock the platform
        public EditViewModelTests(WorldExplorerAPIFactory<Startup> factory)
        {
            _factory = factory;
            var scope = factory.Services.CreateScope();
            WebApplicationFactoryClientOptions options = new WebApplicationFactoryClientOptions();
            options.MaxAutomaticRedirections = 1000;
            options.HandleCookies = false;
            _client = _factory.CreateClient(options);

            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;

            var moq = new Mock<UserService>();

            user = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test12345.test123@test.howest.be", Role = "Admin", IsSpotifyDj = false };
            var hasher = new PasswordHasher<User>();
            user.Password = hasher.HashPassword(user, "t}F87)8GBaj<");
            token = moq.Object.GenerateTokenApp(user);
        }
        
        [Fact]
        public async void EditUser_validUser_returns_NoErrorMessage()
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var editViewModel = new EditViewModel(moq.Object);
            editViewModel.Init(user);
            editViewModel.test = true;

            //Act
            user.FirstName = "test";
            user.LastName = "test";
            user.Email = "test1234.test123@test.howest.be";
            var status = await GetUser(user);
            if (!status.IsSuccessStatusCode)
            {
                editViewModel.EditedUser.ErrorMessage = await status.Content.ReadAsStringAsync();
            }

            //Assert
            Assert.Null(editViewModel.EditedUser.ErrorMessage);
        }

        [Fact]
        public void RegisterCommand_validUserEdit_returns_UserEdit()
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var register = new EditViewModel(moq.Object);

            //Act
            register.Init(user);

            //Assert
            Assert.IsType<UserEdit>(register.EditedUser);
        }

        [Fact]
        public void RegisterCommand_validUserEdit_returns_NotNull()
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var register = new EditViewModel(moq.Object);

            //Act
            register.Init(user);

            //Assert
            Assert.NotNull(register.EditedUser);
        }

        private async Task<HttpResponseMessage> GetUser(User user)
        {
            try
            {
                using (var client = _client)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    string json = JsonConvert.SerializeObject(user);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync($"{url}/users/update/{user.Id}", content);
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
            yield return new object[] { "", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "FirstName" };
            yield return new object[] { null, "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "FirstName" };
            //Invalid LastNames
            yield return new object[] { "test", "", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "LastName" };
            yield return new object[] { "test", null, DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "LastName" };
            //Invalid BirthDates
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-8).Date, "testland", "gaspard.lammertyn@student.howest.be", "BirthDate" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(12).Date, "testland", "gaspard.lammertyn@student.howest.be", "BirthDate" };
            //Invalid Nationalities
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "", "gaspard.lammertyn@student.howest.be", "Nationality" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, null, "gaspard.lammertyn@student.howest.be", "Nationality" };
            //Invalid emails
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "test.studenthowest.be", "Email" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", null, "Email" };
        }


        [Theory]
        [MemberData(nameof(RegisterData))]
        public void GetErrors_ValidatesUser_returns_true(string firstname, string lastname, DateTime dateOfBirth, string nationality, string mail, string property)
        {
            //Arrange
            var moq = new Mock<IAPIinterface>();
            var editViewModel = new EditViewModel(moq.Object);
            editViewModel.Init(user);
            editViewModel.EditedUser = new UserEdit() { FirstName = firstname, LastName = lastname, Nationality = nationality, Email = mail };
            editViewModel.EditedUser.BirthDate = dateOfBirth;

            bool expected = true;
            //Act
            var errors = editViewModel.EditedUser.GetErrors(property).ToList<string>();
            var actual = errors.Any();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
