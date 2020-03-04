using SpotifyAPI.Web.Models;
using System;

namespace WorldExplorerEurope.API.Domain
{
    public class SpotifyPlaylist
    {
        public Guid CountryId { get; set; }

        // Can store multiple tracks via it's Tracks property
        public SeveralTracks Songs { get; set; }
    }
}
