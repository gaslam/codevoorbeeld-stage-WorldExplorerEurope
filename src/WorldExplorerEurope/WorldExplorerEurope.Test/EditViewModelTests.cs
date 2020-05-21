using FakeItEasy;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Helpers;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Services;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class EditViewModelTests
    {
        private IUserService _userService;
        private const string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImE1MzExMjE0LTU2NGYtNDgyNC1iYTY1LWI1NzA0MjM0OWU0OSIsInJvbGUiOiJBZG1pbiIsIm5iZiI6MTU5MDA4MzE5MywiZXhwIjoxNTkwNjg3OTkyLCJpYXQiOjE1OTAwODMxOTN9.kB_B1ILsx3Mqyb8iL3qQZglqxXXcJ_oyTBXPmcrxT2I";

        //Used to mock the platform
        public EditViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public void EditCommand_returns_NoErrorMessage()
        {
            //Arrange
            try
            {
                var user = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin"};
                var editViewModel = new EditViewModel();
                editViewModel.Init(user);
                editViewModel.test = true;
                
                //Act
                editViewModel.EditCommand.Execute(null);

                //Assert
                Assert.Null(editViewModel.EditedUser.ErrorMessage);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]
        public void RegisterCommand_returns_UserEdit()
        {
            //Arrange
            try
            {
                var user = new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token };
                var register = new EditViewModel();

                //Act
                register.Init(user);
                register.test = true;
                register.EditCommand.Execute(null);

                //Assert
                Assert.IsType<UserEdit>(register.EditedUser);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
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
            try
            {
                var user = new User { FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@student.howest.be", Password = "t}F87)8GBaj<", Token = token, Role = "Admin" };
                var editViewModel = new EditViewModel();
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
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }
    }
}
