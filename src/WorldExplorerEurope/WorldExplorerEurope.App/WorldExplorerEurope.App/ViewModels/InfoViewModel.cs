using Android.Provider;
using FreshMvvm;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.SignalR;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Views;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class InfoViewModel : FreshBasePageModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private Country _country;

        private IAPIinterface _apiService;
        private LocalService _localService;
        private ExplorerHubViewModel explorerHubViewModel;
        private HubConnection connection;

        public InfoViewModel(IAPIinterface _apiService)
        {
            this._apiService = _apiService;
            _localService = new LocalService();
            explorerHubViewModel = new ExplorerHubViewModel();
        }

        public bool test = false;

        public async override void Init(object initData)
        {
            var country = initData as Country;
            this._country = country;
            this.countryPlaylist = GetCountryPlaylist().Result;
            UserMemories = await GetUserMemories();
            ActivityIndicator = false;
            ChangePageContentBasedOnUser();
            AddedInFavourites = $"Times added: {_country.favourites.Count}";
            AddedInWishlist = $"Times added: {_country.countryWishlists.Count}";
            await explorerHubViewModel.Connect();
            if (explorerHubViewModel.IsConnected == true)
            {
                connection = getHubConnection();
                addConnectionEventHandler();
            }
            base.Init(initData);

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

        private void addConnectionEventHandler()
        {
            connection.On<string>("addFavourites", (string country) =>
            {
                _country = JsonConvert.DeserializeObject<Country>(country);
                updateFavouriteAndWishlistCount(_country);
            });
        }
        
        private void ChangePageContentBasedOnUser()
        {
            var user = User;
            if (user == null) user = _localService.GetUser();
            int count = 0;
            int count2 = 0;
            if (user != null) count = _country.favourites.Where(m => m.UserId == user.Id).Count();
            if (count > 0)
            {
                LblFavouritesText = "Remove from Favourites";
                FavouriteCommand = RemoveFavouriteCommand;
            }
            else
            {
                LblFavouritesText = "Add to Favourites";
                FavouriteCommand = AddFavouriteCommand;
            }
            if (user != null) count2 = _country.countryWishlists.Where(m => m.UserId == user.Id).Count();
            if (count2 > 0)
            {
                LblWishlistsText = "Remove from Wishlist";
                WishlistCommand = RemoveWishlistCommand;
            }
            else
            {
                LblWishlistsText = "Add to Wishlist";
                WishlistCommand = AddWishlistCommand;
            }
        }
        #region properties

        public string CountryName
        {
            get
            {
                return _country.Name;
            }
        }

        public string Capital
        {
            get
            {
                return _country.Capital;
            }
        }

        public bool IsEUmember
        {
            get
            {
                return _country.IsEUMember;
            }
        }

        public long Population
        {
            get
            {
                return _country.Population;
            }
        }

        public string Currency
        {
            get
            {
                return _country.Currency;
            }
        }

        private ObservableCollection<BasicPlaylist> countryPlaylist;
        public ObservableCollection<BasicPlaylist> CountryPlaylist
        {
            get
            {
                return this.countryPlaylist;
            }

            set
            {
                countryPlaylist = GetCountryPlaylist().Result;
            }
        }

        public string Description
        {
            get
            {
                return $"{_country.Description}\n\n© Wikipedia";
            }
        }

        public List<PhotoMemoryDto> Memories
        {
            get
            {
                return _country.countryPhotoMemories;
            }
        }

        public List<Wishlist> Wishlists
        {
            get
            {
                return _country.countryWishlists;
            }
        }

        public List<Favourite> Favourites
        {
            get
            {
                return _country.favourites;
            }
        }
        #endregion

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool activityIndicator;
        public bool ActivityIndicator
        {
            get { return activityIndicator; }
            set
            {
                this.activityIndicator = value;
                ChangeProperty(nameof(ActivityIndicator));
            }
        }

        private ObservableCollection<PhotoMemoryDto> userMemories;
        public ObservableCollection<PhotoMemoryDto> UserMemories
        {
            get
            {
                return userMemories;
            }

            set
            {
                userMemories = value;
                ChangeProperty(nameof(UserMemories));
            }
        }

        private string lblFavouritesText;
        public string LblFavouritesText
        {
            get
            {
                return lblFavouritesText;
            }
            set
            {
                lblFavouritesText = value;
                ChangeProperty(nameof(LblFavouritesText));
            }
        }

        private string lblWishlistsText;
        public string LblWishlistsText
        {
            get
            {
                return lblWishlistsText;
            }
            set
            {
                lblWishlistsText = value;
                ChangeProperty(nameof(LblWishlistsText));
            }
        }


        private async Task<ObservableCollection<PhotoMemoryDto>> GetUserMemories()
        {
            var user = User;
            if (user == null) user = _localService.GetUser();
            if (user == null)
            {
                return new ObservableCollection<PhotoMemoryDto>();
            }
            var memories = new ObservableCollection<PhotoMemoryDto>(_country.countryPhotoMemories.Where(m => m.UserId == user.Id).ToList());
            return new ObservableCollection<PhotoMemoryDto>(new ObservableCollection<PhotoMemoryDto>(_country.countryPhotoMemories.Where(m => m.UserId == user.Id).ToList()));
        }

        private string addedInFavourites;
        public string AddedInFavourites
        {
            get
            {
                return addedInFavourites;
            }
            set
            {
                addedInFavourites = value;
                ChangeProperty(nameof(AddedInFavourites));
            }
        }

        private string addedInWishlist;

        public string AddedInWishlist
        {
            get
            {
                return addedInWishlist;
            }
            set
            {
                addedInWishlist = value;
                ChangeProperty(nameof(AddedInWishlist));
            }
        }

        private Uri playlistLink;

        public ICommand OpenPlaylistInBrowser => new Command(
            async () =>
            {
                if (playlistLink != null)
                    await Launcher.OpenAsync(playlistLink);
                else
                    await Application.Current.MainPage.DisplayAlert("Cannot open link!!", "This country does not have a playlist yet.\nPlease, suggest us some songs if you want😀", "ok😁");
            });

        public async Task<ObservableCollection<BasicPlaylist>> GetCountryPlaylist()
        {
            try
            {
                string response = await _apiService.Get($"{WorldExplorerAPIService.BaseUrl}/spotifyplaylists/playlists/Country/{_country.Id}");
                var playlist = JsonConvert.DeserializeObject<CountryPlaylist>(response);
                ObservableCollection<BasicPlaylist> newBasicPlaylist = new ObservableCollection<BasicPlaylist>();
                foreach (var track in playlist.Playlist)
                {
                    BasicPlaylist basicPlaylist = new BasicPlaylist
                    {
                        Name = track.Name,
                        Number = track.Number,
                        PreviewUrl = track.PreviewUrl,
                        Artists = track.Artists
                    };
                    newBasicPlaylist.Add(basicPlaylist);

                }
                playlistLink = playlist.Url;
                return newBasicPlaylist;
            }
            catch
            {
                return new ObservableCollection<BasicPlaylist>();
            }
        }

        public ICommand PhotoCommand => new Command(
            async () =>
            {
                string action = await App.Current.MainPage.DisplayActionSheet("What do you want to do?", "Cancel", null, "Take a picture", "Get a picture");
                ActivityIndicator = true;
                var user = User;
                if (user == null) _localService.GetUser();
                if (user == null)
                {
                    await App.Current.MainPage.DisplayAlert("Login!!", "Please, login before you upload.", "Ok");
                    await CoreMethods.PushPageModel<LoginViewModel>(true);
                    return;
                }

                if (action == "Take a picture")
                {
                    await TakePicture();
                }
                if (action == "Get a picture")
                {
                    await PickPicture();
                }
            });

        //This is code I wanted to implement, but for some reason it does not work
        private async Task<bool> CheckAndroidCameraPermissions()
        {
            Plugin.Permissions.Abstractions.PermissionStatus status = await CrossPermissions.Current.CheckPermissionStatusAsync<CalendarPermission>();
            if (status != Plugin.Permissions.Abstractions.PermissionStatus.Granted)
            {
                status = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                return true;
            }

            if (status == Plugin.Permissions.Abstractions.PermissionStatus.Granted)
            {
                return true;
            }
            return false;
        }

        private async Task TakePicture()
        {
            await CrossMedia.Current.Initialize();
            var camera = DependencyService.Get<ICameraService>();
            var hasPermission = await camera.CheckAndroidCameraPermissions();
            if (!hasPermission)
            {
                await App.Current.MainPage.DisplayAlert("Permission denied", "Please, enable camera and storage access for this app in your settings.", "OK");
            }
            var file = await camera.TakePicture();


            if (file == null)
            {
                return;
            }
            await CreateFormData(file);
        }

        private async Task PickPicture()
        {
            await CrossMedia.Current.Initialize();
            var camera = DependencyService.Get<ICameraService>();
            var hasPermission = camera.CheckAndroidCameraPermissions();
            var file = await camera.PickPicture();


            if (file == null)
            {
                await App.Current.MainPage.DisplayAlert("Cannot", "Cannot take picture.", "Ok");
                return;
            }
            await CreateFormData(file);
        }

        private async Task CreateFormData(MediaFile media)
        {
            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(media.GetStream()), "\"file\"", $"\"{media.Path}\"");
            var upload = await UploadPicture(content);
            if (!upload.IsSuccessStatusCode) await App.Current.MainPage.DisplayAlert("Error", "Cannot perform action.", "OK");
            else
            {
                string responseContent = await upload.Content.ReadAsStringAsync();
                var country = JsonConvert.DeserializeObject<Country>(responseContent);
                _country = country;
                ActivityIndicator = false;
            }
        }

        private async Task<HttpResponseMessage> UploadPicture(MultipartFormDataContent content)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var user = _localService.GetUser();
                    ActivityIndicator = false;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
                    return await client.PostAsync($"{WorldExplorerAPIService.BaseUrl}/{_country.Id}/{user.Id}/memory", content);
                }
            }
            catch
            {
                ActivityIndicator = false;
                return null;
            }
            return null;
        }

        private ICommand favouriteCommand;
        public ICommand FavouriteCommand
        {
            get
            {
                return favouriteCommand;
            }
            set
            {
                favouriteCommand = value;
                ChangeProperty(nameof(FavouriteCommand));
            }
        }

        private ICommand wishlistCommand;
        public ICommand WishlistCommand
        {
            get
            {
                return wishlistCommand;
            }
            set
            {
                wishlistCommand = value;
                ChangeProperty(nameof(WishlistCommand));
            }
        }

        public ICommand AddFavouriteCommand => new Command(
            async () =>
            {
                var user = User;
                if (user == null) user = _localService.GetUser();
                if (user != null)
                {
                    await Add($"{WorldExplorerAPIService.BaseUrl}/{_country.Id}/{user.Id}/favourites");
                    var countries = await _localService.GetCountriesAsync();
                    var updatedCountry = countries.FirstOrDefault(m => m.Name == _country.Name);
                    updateFavouriteAndWishlistCount(updatedCountry);
                    return;
                }
                if(test == false)
                {
                    await App.Current.MainPage.DisplayAlert("Login!!", "Please, login before adding", "OK");
                    await CoreMethods.PushPageModel<LoginViewModel>(true);
                }
            });

        ICommand RemoveFavouriteCommand => new Command(
            async () =>
            {
                var user = User;
                if (user == null) user = _localService.GetUser();
                var favourite = _country.favourites.FirstOrDefault(m => m.UserId == user.Id);
                await Remove($"{WorldExplorerAPIService.BaseUrl}/favourites/remove/{_country.Id}/{favourite.Id}", user.Token);
                var countries = await _localService.GetCountriesAsync();
                var updatedCountry = countries.FirstOrDefault(m => m.Name == _country.Name);
                updateFavouriteAndWishlistCount(updatedCountry).Wait();
            });

        ICommand AddWishlistCommand => new Command(
            async () =>
            {
                var user = User;
                if (user == null) user = _localService.GetUser();
                if (user != null)
                {
                    await Add($"{WorldExplorerAPIService.BaseUrl}/{_country.Id}/{user.Id}/wishlist");
                    var countries = await _localService.GetCountriesAsync();
                    var updatedCountry = countries.FirstOrDefault(m => m.Name == _country.Name);
                    updateFavouriteAndWishlistCount(updatedCountry).Wait();
                    return;
                }
                if(test == false)
                {
                    await App.Current.MainPage.DisplayAlert("Login!!", "Please, login before adding", "OK");
                    await CoreMethods.PushPageModel<LoginViewModel>(true);
                }
            });

        private async Task updateFavouriteAndWishlistCount(Country country)
        {
            _country = country;
            AddedInWishlist = $"Times added: {_country.countryWishlists.Count}";
            AddedInFavourites = $"Times added: {_country.favourites.Count}";
            ChangePageContentBasedOnUser();
        }

        ICommand RemoveWishlistCommand => new Command(
            async () =>
            {
                var user = User;
                if (user == null) user = _localService.GetUser();
                var wishlist = _country.countryWishlists.SingleOrDefault(m => m.UserId == user.Id);
                await Remove($"{WorldExplorerAPIService.BaseUrl}/wishlists/remove/{_country.Id}/{wishlist.Id}", user.Token);
                var countries = await _localService.GetCountriesAsync();
                var updatedCountry = countries.FirstOrDefault(m => m.Name == _country.Name);
                updateFavouriteAndWishlistCount(updatedCountry);
            });

        private async Task Add(string url)
        {
            var user = User;
            if (user == null) user = _localService.GetUser();
            string rawJSON = JsonConvert.SerializeObject(_country);
            var response = await _apiService.Put(url, rawJSON, user.Token);
            if (!response.IsSuccessStatusCode) await App.Current.MainPage.DisplayAlert("Error", "Cannot perform action.", "OK");
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                var country = JsonConvert.DeserializeObject<Country>(responseContent);
                await explorerHubViewModel.UpdateLists(country);
            }
        }

        private HubConnection getHubConnection()
        {
            return explorerHubViewModel.GetHub();
        }

        private async Task Remove(string url, string token)
        {
            var response = await _apiService.Delete(url, token);
            if (!response.IsSuccessStatusCode) await App.Current.MainPage.DisplayAlert("Error", "Cannot perform action.", "OK");
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                var country = JsonConvert.DeserializeObject<Country>(responseContent);
                _country = country;
                await explorerHubViewModel.UpdateLists(_country);
            }
        }

        public ICommand PlayTrackPreview() => new Command(
            async () =>
            {

            });

    }
}
