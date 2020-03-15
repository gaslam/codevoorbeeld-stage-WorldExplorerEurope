using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.API.Domain.DTO
{
    public class SpotifyTracksDto
    {
        public string PlaylistId  { get; set; }

        //Contains the tracks from Spotify via it's .Tracks property
        public SeveralTracks PlaylistTracks { get; set; }
    }
}
