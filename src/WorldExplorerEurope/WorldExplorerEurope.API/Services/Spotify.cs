using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldExplorerEurope.API.Services
{
    public class Spotify
    {
        //Contains all the code for getting the spotify API data.
        private static SpotifyWebAPI _spotify;
        private const string clientId = "e1e36ceac985420e9c65c12f450045da";
        private const string clientSecret = "5d151d54fa7a4be9a5d473201f072ea5";
        // Is used for to create the tokens to access the API.
        private static Token token = new Token();
        //Is Used to get the credentials of the application for the spotify API.
        private static CredentialsAuth credentials;
        public Spotify()
        {
            CallAPI();
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

        public async Task<SeveralTracks> GetTracks(string id)
        {
            if (token.IsExpired())
            {
                await AccessAPI();
            }
            var spotifyPlaylist = _spotify.GetPlaylistTracks("", id, 1000, 0, "BE");
            SeveralTracks top5Tracks = new SeveralTracks();
            spotifyPlaylist.Items.ForEach(track => top5Tracks.Tracks.Add(track.Track));
            return top5Tracks;
        }

        public async Task<SimplePlaylist> GetPlaylist(string searchterm)
        {
            if (token.IsExpired())
            {
                await AccessAPI();
            }
            var playlist = _spotify.SearchItems($"{searchterm}", SearchType.Playlist, 1, 0, "BE");

            return playlist.Playlists.Items[0];
        }
    }
}
