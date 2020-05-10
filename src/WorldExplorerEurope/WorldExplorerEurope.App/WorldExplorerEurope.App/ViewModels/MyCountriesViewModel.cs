using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class MyCountriesViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Country> _country;
        LocalService localService = new LocalService();

        public async override void Init(object initData)
        {
            base.Init(initData);
            _country = await GetCountries();
            ActivityIndicator = false;
            GetCountryByWishlist();
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
            var user = localService.GetUser();
            ObservableCollection<Country> wishlistCountries = new ObservableCollection<Country>();
            foreach (var country in _country)
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
                 var user = localService.GetUser();
                 ObservableCollection<Country> favouritesCountries = new ObservableCollection<Country>();
                 foreach (var country in _country)
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
