using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;

namespace WorldExplorerEurope.API.Services
{
    public class Spotify
    {
        //Contains all the code for getting the spotify API data.
        private static SpotifyWebAPI _spotify;

        /*Just to be clear, I know hardcoding is not a good practice.
         * Back then I did not know you could store them in de secrets file.
         * I decided not to change it because I do not currently have a lot of time.
         */
        private const string clientId = "(YOUR CLIENT ID OF YOUR SPOTIFY APP)";
        private const string clientSecret = "(YOUR SECRET ID OF YOUR SPOTIFY APP)";
        // Is used for to create the tokens to access the API.
        private static Token token = new Token();
        //Is Used to get the credentials of the application for the spotify API.
        private static CredentialsAuth credentials;
        public Spotify()
        {
            CallAPI();
            _spotify = new SpotifyWebAPI();
        }

        private async void CallAPI()
        {
            await AccessAPI();
        }

        /*
         <Summary>
            Gets the credentials of my spotify app first.
            Than it gets the token and adds them to _spotify.
            This will let us access the Spotify playlists in (a later method).
         </Summary> 
        */
        private async Task<SpotifyWebAPI> AccessAPI()
        {
            credentials = new CredentialsAuth(clientId, clientSecret);
            token = await credentials.GetToken();
            _spotify = new SpotifyWebAPI()
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType
            };
            return _spotify;
        }

        /*
         <Summary>
            Token is not always valid.
            If token.IsExpired is true,
            AccessAPI will be called again.
         </Summary> 
        */
        public async Task<bool> CheckClientCredentials()
        {
            try
            {
                if (token.IsExpired())
                {
                    await AccessAPI();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        /*
         * <summary>
         *  Get's the first 100 tracks of a playlist.
         *  I wanted to display the tracks of the spotify playlist but with a limit. I believe 100 is enough.
         *  </summary>
         */
        public async Task<List<SpotifyBasicTracksDto>> GetFirst100Tracks(FullPlaylist playlist)
        {
            if (_spotify == null || token.IsExpired())
            {
                _spotify = new SpotifyWebAPI();
                await AccessAPI();
            }

            var tracks = await _spotify.GetPlaylistTracksAsync(playlist.Id, "", 100, 1, "BE");
            List<SpotifyBasicTracksDto> spotifyBasicTracks = new List<SpotifyBasicTracksDto>();
            if (tracks.Items == null) return null;
            for (int i = 0; i < tracks.Items.Count; i++)
            {
                var track = tracks.Items[i];
                SpotifyBasicTracksDto spotifyBasicTracksDto = new SpotifyBasicTracksDto
                {
                    Number = i + 1,
                    Name = track.Track.Name,
                    Artists = ConvertArtistsToString(track.Track.Artists)
                };
                if (track.Track.PreviewUrl == null)
                {
                    //Cannot pass empty url's so if 
                    spotifyBasicTracksDto.PreviewUrl = new Uri("https://www.spotify.com/");
                }
                else
                {
                    spotifyBasicTracksDto.PreviewUrl = new Uri(track.Track.PreviewUrl);
                }
                spotifyBasicTracks.Add(spotifyBasicTracksDto);
            }
            return spotifyBasicTracks;
        }

        /*
         * <summary>
         *  Translates the a list of SimpleArtist to a string.
         *  </summary>
         */
        private string ConvertArtistsToString(List<SimpleArtist> artists)
        {
            StringBuilder combinedArtists = new StringBuilder();
            if (artists.Count == 1)
            {
                combinedArtists.Append(artists[0].Name);
            }
            else
            {
                foreach (var artist in artists)
                {
                    combinedArtists.Append(artist.Name).Append(", ");
                }
            }
            return combinedArtists.ToString();
        }

        /*
         * <summary>
         *  Returns a spotify playlist.
         *  The market is set to belgium, because there are no actual plans to release it. That's why I decided to set it to my country.
         *  </summary>
         */
        public async Task<FullPlaylist> GetFullPlaylist(string id)
        {
            if (token.IsExpired())
            {
                await AccessAPI();
            }
            return await _spotify.GetPlaylistAsync(id, "", "BE");
        }
    }
}
