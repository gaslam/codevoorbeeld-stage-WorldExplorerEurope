using FreshMvvm;
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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Views;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class InfoViewModel : FreshBasePageModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private Country _country;

        private IAPIinterface _apiService;
        private MainViewModel mainViewModel = new MainViewModel();

        public InfoViewModel()
        {
            this._apiService = new APIservice();
        }

        public async override void Init(object initData)
        {
            var country = initData as Country;
            this._country = mainViewModel.GetCountry();
            this.countryPlaylist = GetCountryPlaylist().Result;
            ActivityIndicator = false;
            base.Init(initData);

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

        private async Task<ObservableCollection<BasicPlaylist>> GetCountryPlaylist()
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
                return newBasicPlaylist;
            }
            catch
            {
                return null;
            }
        }

        public ICommand PhotoCommand => new Command(
            async () =>
            {
                string action = await App.Current.MainPage.DisplayActionSheet("What do you want to do?", "Cancel", null, "Take a picture", "Get a picture");
                ActivityIndicator = true;
                LocalService localService = new LocalService();
                if(localService.GetUser() == null)
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
            PermissionStatus status = await CrossPermissions.Current.CheckPermissionStatusAsync<CalendarPermission>();
            if (status != PermissionStatus.Granted)
            {
                status = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                return true;
            }

            if (status == PermissionStatus.Granted)
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


            if(file == null)
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


            if(file == null)
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
            if (!upload.IsSuccessStatusCode)
            {
                await App.Current.MainPage.DisplayAlert("Cannot upload picture", "The service is currently unavailable.\n Just wait 1 hour and try again.", "Ok");
                ActivityIndicator = false;
            }
            else
            {
                var pagetorefresh = new LoginViewModel();
                CoreMethods.RemoveFromNavigation<InfoViewModel>(false);
                await CoreMethods.PushPageModel<InfoViewModel>(_country, false, true);
                ActivityIndicator = false;
            }
        }

        private async Task<HttpResponseMessage> UploadPicture(MultipartFormDataContent content)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    LocalService localService = new LocalService();
                    var user = localService.GetUser();
                    ActivityIndicator = false;
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
    }
}
