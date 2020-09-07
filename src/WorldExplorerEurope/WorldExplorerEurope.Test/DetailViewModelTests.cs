using FakeItEasy;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class DetailViewModelTests
    {
        //Used to mock the platform
        public DetailViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }


        [Fact]
        public void Init_CreatesUser_returns_UserType()
        {
            //Arrange
            var user = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(user);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            Assert.IsType<User>(detailUser);
        }

        [Fact]
        public void Init_CreatesUser_compares_Date()
        {
            //Arrange
            var user = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date, Password="", Role="", Token="", IsSpotifyDj = false };
            string expected = user.BirthDate.ToShortDateString();
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(user);
            //Act
            string actual = detailViewModel.BirthDate;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Init_CreatesUser_returns_NotNull_FirstName()
        {
            //Arrange
            var expected = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(expected);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            Assert.NotNull(detailUser.FirstName);
        }

        [Fact]
        public void Init_CreatesUser_returns_NotNull_LastName()
        {
            //Arrange
            var expected = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(expected);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            Assert.NotNull(detailUser.LastName);
        }

        [Fact]
        public void Init_CreatesUser_returns_NotNull_Nationality()
        {
            //Arrange
            var expected = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(expected);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            Assert.NotNull(detailUser.Nationality);
        }

        [Fact]
        public void Init_CreatesUser_returns_NotNull_BirthDate()
        {
            //Arrange
            var expected = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(expected);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            //Ik kreeg hiervoor een waarschuwing dus converteer ik het hier naar een string.
            Assert.NotNull(detailUser.BirthDate.ToShortDateString());
        }

        [Fact]
        public void Init_CreatesUser_returns_NotNull_Email()
        {
            //Arrange
            var expected = new User() { FirstName = "test", LastName = "test", Nationality = "testland", Email = "test@student.howest.be", BirthDate = DateTime.Now.AddYears(-12).Date };
            var detailViewModel = new DetailViewModel();
            detailViewModel.Init(expected);
            //Act
            var detailUser = detailViewModel.GetUser();
            //Assert
            Assert.NotNull(detailUser.Email);
        }
    }
}
