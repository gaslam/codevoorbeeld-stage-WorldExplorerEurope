using FakeItEasy;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace WorldExplorerEurope.Test
{
    public class MyCountriesViewModelTests
    {
        public MyCountriesViewModelTests()
        {
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        private void WishlistsCommand_NewWishlist_returns_NotNull()
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
            myCountriesVM.Init(moq.Object);

            //Act
            myCountriesVM.WishlistsCommand.Execute(null);

            //Assert
            Assert.NotNull(myCountriesVM.Countries);

        }

        [Fact]
        private void WishlistsCommand_NewWishlist_returns_ObservableCollection()
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
            myCountriesVM.Init(moq.Object);

            //Act
            myCountriesVM.WishlistsCommand.Execute(null);

            //Assert
            Assert.IsType<ObservableCollection<Country>>(myCountriesVM.Countries);

        }

        [Fact]
        private void FavouritesCommand_NewWishlist_returns_NotNull()
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
            myCountriesVM.Init(moq.Object);

            //Act
            myCountriesVM.FavouritesCommand.Execute(null);

            //Assert
            Assert.NotNull(myCountriesVM.Countries);

        }

        [Fact]
        private void FavouritesCommand_NewWishlist_returns_ObservableCollection()
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
            myCountriesVM.Init(moq.Object);

            //Act
            myCountriesVM.FavouritesCommand.Execute(null);

            //Assert
            Assert.IsType<ObservableCollection<Country>>(myCountriesVM.Countries);

        }
    }
}
