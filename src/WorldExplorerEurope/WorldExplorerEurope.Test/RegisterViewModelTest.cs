using FakeItEasy;
using Moq;
using Syncfusion.DataSource.Extensions;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class RegisterViewModelTests
    {
        private const string url = "https://localhost:5001/api/countries";


        //Used to mock the platform
        public RegisterViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public void RegisterCommand_returns_NoErrorMessage()
        {
            //Arrange
            try
            {
                var moq = new Mock<RegisterViewModel>();
                var register = new RegisterViewModel();
                register.Init(moq.Object);
                register.test = true;
                register.newUser = new UserRegister() { FirstName = "test", LastName = "test", BirthDate = DateTime.Now.AddYears(-18).Date, Nationality = "testland", Email = "test.test@test.howest.be", Password = "t}F87)8GBaj<" };
                //Act
                register.RegisterCommand.Execute(null);

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
            try
            {
                var moq = new Mock<RegisterViewModel>();
                var register = new RegisterViewModel();

                //Act
                register.Init(moq.Object);
                register.test = true;
                register.RegisterCommand.Execute(null);

                //Assert
                Assert.IsType<UserRegister>(register.newUser);

            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
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
            yield return new object[] { "test", "test",DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", null, "t}F87)8GBaj<", "Password" };
            yield return new object[] { "test", "test",DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "", "t}F87)8GBaj<", "Password" };
            yield return new object[] { "test", "test",DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F88Baj<", "t}F87)8GBaj<", "Password" };
            //Invalid Repeated Passwords
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", "", "PasswordRepeat" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "t}F87)8GBaj<", null, "PasswordRepeat" };
            yield return new object[] { "test", "test", DateTime.Now.AddYears(-12).Date, "testland", "gaspard.lammertyn@student.howest.be", "", "t}F87)8GBaj<", "PasswordRepeat" };
        }


        [Theory]
        [MemberData(nameof(RegisterData))]
        public void GetErrors_ValidatesUser_returns_true(string firstname, string lastname, DateTime dateOfBirth , string nationality, string mail, string password, string passwordRepeat, string property)
        {
            //Arrange
            try
            {
                var moq = new Mock<RegisterViewModel>();
                var loginViewModel = new RegisterViewModel();
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
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }
    }
}
