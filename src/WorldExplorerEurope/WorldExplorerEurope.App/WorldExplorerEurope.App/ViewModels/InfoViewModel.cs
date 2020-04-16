using FreshMvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels.Syncfusion;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;

namespace WorldExplorerEurope.App.ViewModels
{
    public class InfoViewModel : FreshBasePageModel
    {
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
            base.Init(country);

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

        public List<Memory> Memories
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

        private async Task<ObservableCollection<BasicPlaylist>> GetCountryPlaylist()
        {
            try
            {
                string response = await _apiService.Get($"{WorldExplorerAPIService.BaseUrl}/spotifyplaylists/playlists/Country/{_country.Id}");
                var playlist = JsonConvert.DeserializeObject<CountryPlaylist>(response);
                ObservableCollection<BasicPlaylist> newBasicPlaylist = new ObservableCollection<BasicPlaylist>();
                foreach(var track in playlist.Playlist)
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
    }
}
