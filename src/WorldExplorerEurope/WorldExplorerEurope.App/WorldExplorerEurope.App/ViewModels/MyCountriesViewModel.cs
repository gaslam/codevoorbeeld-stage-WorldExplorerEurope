using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class MyCountriesViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Country> countryList;
        LocalService localService = new LocalService();
        public bool test = false;

        public async override void Init(object initData)
        {
            base.Init(initData);
            if(test == false)countryList = await GetCountries();
            ActivityIndicator = false;
            if(test == false)GetCountryByWishlist();
        }

        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get
            {
                return countries;
            }
            set
            {
                this.countries = value;
                ChangeProperty(nameof(Countries));
            }
        }

        //Deze variable is alleen geschreven voor te Unit testen. Verder doe ik niks hiermee
        private User user;
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                this.user = value;
                ChangeProperty(nameof(User));
            }
        }

        public async Task<ObservableCollection<Country>> GetCountries()
        {
            try
            {
                LocalService localService = new LocalService();
                var countries = await localService.GetCountriesAsync();
                return countries;
            }
            catch
            {
                return null;
            }

        }

        private bool activityIndicator;

        public bool ActivityIndicator
        {
            get
            {
                return activityIndicator;
            }
            set
            {
                activityIndicator = value;
                ChangeProperty(nameof(ActivityIndicator));
            }
        }

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void GetCountryByWishlist()
        {
            ActivityIndicator = true;
            var user = User;
            if (user == null) user = localService.GetUser();
            ObservableCollection<Country> wishlistCountries = new ObservableCollection<Country>();
            foreach (var country in countryList)
            {
                var wishlist = country.countryWishlists.FirstOrDefault(m => m.UserId == user.Id);
                if (wishlist != null) wishlistCountries.Add(country);
            }
            Countries = wishlistCountries;
            ActivityIndicator = false;
        }
        public ICommand FavouritesCommand => new Command(
             () =>
             {
                 ActivityIndicator = true;
                 var user = User;
                 if (user == null) user = localService.GetUser();
                 ObservableCollection<Country> favouritesCountries = new ObservableCollection<Country>();
                 foreach (var country in countryList)
                 {
                     var wishlist = country.favourites.FirstOrDefault(m => m.UserId == user.Id);
                     if (wishlist != null) favouritesCountries.Add(country);
                 }
                 Countries = favouritesCountries;
                 ActivityIndicator = false;
             });

        public ICommand WishlistsCommand => new Command(
             () =>
            {
                GetCountryByWishlist();
            });

        public ICommand LogoutCommand => new Command(
             () =>
             {
                 localService.RemoveUser();
                 CoreMethods.PushPageModel<LoginViewModel>(true);
             });
    }
}
