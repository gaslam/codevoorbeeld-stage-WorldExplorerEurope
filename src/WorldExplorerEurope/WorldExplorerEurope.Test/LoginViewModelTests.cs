using AutoMapper;
using FakeItEasy;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Syncfusion.DataSource.Extensions;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class LoginViewModelTests
    {
        private const string url = "https://localhost:5001/api/countries";


        //Used to mock the platform
        public LoginViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public void LoginCommand_returns_NoErrorMessage()
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();
                loginViewModel.Init(moq.Object);
                loginViewModel.test = true;
                loginViewModel.newUser = new UserLogin() { Email = "gaspard.lammertyn@student.howest.be", Password = "t}F87)8GBaj<" };
                //Act
                loginViewModel.LoginCommand.Execute(null);

                //Assert
                Assert.Null(loginViewModel.newUser.ErrorMessage);

            }
            catch(Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]
        public void LoginCommand_returns_UserLogin()
        {
            //Arrange
            try
            {
                var moq = new Mock<LoginViewModel>();
                var loginViewModel = new LoginViewModel();

                //Act
                loginViewModel.Init(moq.Object);
                loginViewModel.test = true;
                loginViewModel.LoginCommand.Execute(null);

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
