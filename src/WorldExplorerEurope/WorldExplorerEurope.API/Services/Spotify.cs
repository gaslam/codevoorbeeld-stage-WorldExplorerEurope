using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
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
        private const string clientId = "";
        private const string clientSecret = "";
        // Is used for to create the tokens to access the API.
        private static Token token = new Token();
        //Is Used to get the credentials of the application for the spotify API.
        private static CredentialsAuth credentials;
        public Spotify()
        {
            AccessAPI();
        }

        /*
         <Summary>
            Gets the credentials of my spotify app first.
            Than it gets the token and adds them to _spotify.
            This will let us access the Spotify playlists in (a later method).
         </Summary> 
        */
        private async void AccessAPI()
        {
            credentials = new CredentialsAuth(clientId, clientSecret);
            token = await credentials.GetToken();
            _spotify = new SpotifyWebAPI()
            {
                AccessToken = token.AccessToken,
                TokenType = token.TokenType
            };
        }

        /*
         <Summary>
            Token is not always valid.
            If token.IsExpired is true,
            AccessAPI will be called again.
         </Summary> 
        */
        public bool CheckClientCredentials()
        {
            try
            {
                if (token.IsExpired())
                {
                    AccessAPI();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
